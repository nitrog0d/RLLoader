#include "Core.h"
#include <iostream>
#include <string>
#include <fstream>
#include "../Exports/Exports.h"

#define NETHOST_USE_AS_STATIC
#include <nethost.h>

#include <hostfxr.h>
#include <coreclr_delegates.h>

#include "../INIReader/INIReader.h"
#include <thread>

typedef void (RLLoader_NativeEntryPoint_Init_t)();

void Core::InitializeDomain() {
    INIReader ini("rlloader_coreclr.ini");

    if (ini.ParseError() < 0) {
        Error(std::wstring(L"Failed to load rlloader_coreclr.ini!\nResult: ") + std::to_wstring(ini.ParseError()));
        return;
    }

    auto enabled = ini.GetBoolean("General", "Enabled", false);

    if (!enabled) return;

    // Pre-allocate a large buffer for the path to hostfxr
    char_t buffer[MAX_PATH];
    auto buffer_size = sizeof(buffer) / sizeof(char_t);

    auto rc = get_hostfxr_path(buffer, &buffer_size, nullptr);
    if (rc != 0) {
        Error(std::wstring(L"Failed to get hostfxr path! Make sure you have .NET 8.0 runtime installed.\nResult: ") + std::to_wstring(rc));
        return;
    }

    auto hostfxr = LoadLibrary(buffer);

    if (hostfxr == 0) {
        Error(std::wstring(L"Failed to load hostfxr!\nPath: ") + std::wstring(buffer));
        return;
    }

    std::wcout << L"[RLLoader.CoreCLRHost] HostFXR path: " << buffer << std::endl;

    auto hostfxr_initialize_for_runtime_config = (hostfxr_initialize_for_runtime_config_fn)GetProcAddress(hostfxr, "hostfxr_initialize_for_runtime_config");
    auto hostfxr_get_runtime_delegate = (hostfxr_get_runtime_delegate_fn)GetProcAddress(hostfxr, "hostfxr_get_runtime_delegate");
    auto hostfxr_close = (hostfxr_close_fn)GetProcAddress(hostfxr, "hostfxr_close");

    auto rawDirectory = ini.GetString("General", "Directory", "");
    rawDirectory.erase(std::remove(rawDirectory.begin(), rawDirectory.end(), '\"'), rawDirectory.end());

    std::cout << "[RLLoader.CoreCLRHost] Raw directory: " << rawDirectory << std::endl;

    std::filesystem::path directory(rawDirectory);
    std::cout << "[RLLoader.CoreCLRHost] hostfxr_initialize_for_runtime_config" << std::endl;
    hostfxr_handle ctx = nullptr;
    rc = hostfxr_initialize_for_runtime_config((directory / "RLLoader.CoreCLR.runtimeconfig.json").wstring().c_str(), nullptr, &ctx);
    if (rc != 0 || ctx == nullptr) {
        Error(std::wstring(L"Init failed! The path for RLLoader.CoreCLR is probably wrong!\nRC: ") + std::to_wstring(rc));
        hostfxr_close(ctx);
        return;
    }

    std::cout << "[RLLoader.CoreCLRHost] hostfxr_get_runtime_delegate" << std::endl;
    void* load_assembly_and_get_function_pointer_ptr = nullptr;
    rc = hostfxr_get_runtime_delegate(ctx, hdt_load_assembly_and_get_function_pointer, &load_assembly_and_get_function_pointer_ptr);
    if (rc != 0 || load_assembly_and_get_function_pointer_ptr == nullptr) {
        Error(std::wstring(L"Get delegate failed! RC: ") + std::to_wstring(rc));
        hostfxr_close(ctx);
        return;
    }

    hostfxr_close(ctx);

    auto load_assembly_and_get_function_pointer = (load_assembly_and_get_function_pointer_fn)load_assembly_and_get_function_pointer_ptr;

    RLLoader_NativeEntryPoint_Init_t* init = nullptr;

    std::cout << "[RLLoader.CoreCLRHost] load_assembly_and_get_function_pointer" << std::endl;
    rc = load_assembly_and_get_function_pointer(
        (directory / "RLLoader.CoreCLR.dll").wstring().c_str(), 
        L"RLLoader.CoreCLR.NativeEntryPoint, RLLoader.CoreCLR", 
        L"Init", 
        L"RLLoader.CoreCLR.NativeEntryPoint+InitDelegate, RLLoader.CoreCLR",
        nullptr, 
        (void**)&init);

    if (rc != 0 || init == nullptr) {
        Error(std::wstring(L"Failed to get RLLoader.CoreCLR.NativeEntryPoint.Init! RC: ") + std::to_wstring(rc));
        hostfxr_close(ctx);
        return;
    }

    std::cout << "[RLLoader.CoreCLRHost] Calling Init..." << std::endl;
    init();
}

#pragma region Initialization and DLL proxy stuff

bool Core::DEBUG = false;

void Core::Initialize(HINSTANCE hModule) {
    if (strstr(GetCommandLineA(), "--rlloader-debug") != nullptr) DEBUG = true;

    if (DEBUG) {
        AllocConsole();
        freopen_s((FILE**)stdin, "CONOUT$", "w", stdin);
        freopen_s((FILE**)stdout, "CONOUT$", "w", stdout);
        freopen_s((FILE**)stderr, "CONOUT$", "w", stderr);
    }

    std::cout << "[RLLoader.CoreCLRHost] Initializing..." << std::endl;
    // Get execution path
    std::vector<char> pathBuf;
    DWORD copied = 0;
    do {
        pathBuf.resize(pathBuf.size() + MAX_PATH);
        copied = GetModuleFileNameA(nullptr, pathBuf.data(), static_cast<DWORD>(pathBuf.size()));
    } while (copied >= pathBuf.size());

    pathBuf.resize(copied);

    const std::filesystem::path filepath(pathBuf.begin(), pathBuf.end());

    // Get file path of proxy, tolowercase the file name
    const auto proxyFilepath = GetModuleFilePath(hModule);
    auto ProxyFilename = proxyFilepath.filename().wstring();
    std::transform(ProxyFilename.begin(), ProxyFilename.end(), ProxyFilename.begin(), towlower);

    // Make proxy name list
    std::wstring names;
    bool _1 = true;
    for (auto name : Exports::CompatibleFileNames) {
        if (_1) {
            _1 = false;
            names += name;
        }
        else {
            names += L", ";
            names += name;
        }
    }

    bool isProxy = true;

    // Check if is compatible proxy
    std::size_t index = -1;
    if (!Exports::IsFileNameCompatible(ProxyFilename, &index)) {
        // Error(L"Proxy has an incompatible file name!\nValid names are: " + names + L"\n", true);
        isProxy = false;
    }

    // Load original libs
    const HMODULE originalDll = LoadOriginalProxy(proxyFilepath, proxyFilepath.filename().stem().wstring());
    if (isProxy && !originalDll) {
        Error(L"Failed to load original " + proxyFilepath.wstring() + L"!", true);
        return;
    }

    // Load original lib exports
    if (isProxy) Exports::Load(index, originalDll);

    if (strstr(GetCommandLineA(), "--no-rlloader") != nullptr) return;

    // Allow attaching to debug/hot reload
    SetEnvironmentVariable(L"COMPLUS_ForceENC", L"1");

    if (strstr(GetCommandLineA(), "--rlloader-nothreadmode") == nullptr) {
        std::thread initializeDomainThread(InitializeDomain);
        initializeDomainThread.detach();
        std::cout << "[RLLoader.CoreCLRHost] Created Thread." << std::endl;
    } else {
        InitializeDomain();
    }
}

HMODULE Core::LoadOriginalProxy(const std::filesystem::path& proxyFilepath, const std::wstring& proxyFilepathNoExt) {
    HMODULE originalDll = LoadLibraryW((proxyFilepathNoExt + L"_original.dll").c_str());

    if (!originalDll) {
        wchar_t system32_path[MAX_PATH];

        if (GetSystemDirectoryW(system32_path, MAX_PATH) == NULL) {
            Error("Failed to get System32 directory!");
            Core::KillProcess();
            return nullptr;
        }

        const auto path = std::filesystem::path(system32_path);
        originalDll = LoadLibraryW((path / proxyFilepath.filename()).c_str());
    }

    return originalDll;
}

std::filesystem::path Core::GetModuleFilePath(HMODULE moduleHandle) {
    wchar_t path[MAX_PATH];
    GetModuleFileNameW(moduleHandle, path, MAX_PATH);
    return path;
}

void Core::Error(const std::string& reason, const bool shouldKill) {
    MessageBoxA(nullptr, (reason + "\n" + (shouldKill ? "Preventing Startup" : "Continuing without RLLoader") + "...").c_str(), "RLLoader CoreCLR", MB_ICONERROR | MB_OK);
    if (shouldKill) Core::KillProcess();
}

void Core::Error(const std::wstring& reason, const bool shouldKill) {
    MessageBoxW(nullptr, (reason + L"\n" + (shouldKill ? L"Preventing Startup" : L"Continuing without RLLoader") + L"...").c_str(), L"RLLoader CoreCLR", MB_ICONERROR | MB_OK);
    if (shouldKill) KillProcess();
}

void Core::KillProcess() {
    const HANDLE current_process = GetCurrentProcess();
    TerminateProcess(current_process, NULL);
    CloseHandle(current_process);
}

#pragma endregion