using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace RLLoader.SDK;

#pragma warning disable CS0108, CS0114

// Class WinDrv.FacebookWindows
// 0x10 (0xE8 - 0xF8)
// (Compiled | Config | Transient | Parsed | Native)
public unsafe partial class UFacebookWindows : UFacebookIntegration {
    public UFacebookWindows() { }
    public UFacebookWindows(nint pointer) : base(pointer) { }


    // StructProperty WinDrv.FacebookWindows.VfTable_FTickableObject
    // 0xE8 (0x8)
    // (Const | Native | NoExport)
    public nint VfTable_FTickableObject {
        get => *(nint*)(Pointer + 232);
        set => *(nint*)(Pointer + 232) = value;
    }

    // StructProperty WinDrv.FacebookWindows.ChildProcHandle
    // 0xF0 (0x8)
    // (Const | Native | Transient)
    public nint ChildProcHandle {
        get => *(nint*)(Pointer + 240);
        set => *(nint*)(Pointer + 240) = value;
    }


    // Function WinDrv.FacebookWindows.OnFacebookFriendsRequestComplete
    // 0x3750E0
    // (Final | Defined | Private | HasDefaults)
    public unsafe class OnFacebookFriendsRequestComplete_Parameters : BaseObject {
        public OnFacebookFriendsRequestComplete_Parameters() { }
        public OnFacebookFriendsRequestComplete_Parameters(nint pointer) : base(pointer) { }

        // ObjectProperty WinDrv.FacebookWindows.OnFacebookFriendsRequestComplete.OriginalRequest
        // 0x0 (0x8)
        // (Param)
        public UHttpRequestInterface OriginalRequest {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }

        // ObjectProperty WinDrv.FacebookWindows.OnFacebookFriendsRequestComplete.Response
        // 0x8 (0x8)
        // (Param)
        public UHttpResponseInterface Response {
            get {
                var pointer = *(nint*)(Pointer + 8);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 8) = value.Pointer;
        }

        // BoolProperty WinDrv.FacebookWindows.OnFacebookFriendsRequestComplete.bDidSucceed
        // 0x10 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bDidSucceed {
            get => (*(uint*)(Pointer + 16) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 16) |= 0x1;
                else *(uint*)(Pointer + 16) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrOnFacebookFriendsRequestComplete;
    public void OnFacebookFriendsRequestComplete(UHttpRequestInterface OriginalRequest, UHttpResponseInterface Response, bool bDidSucceed) {
        _ptrOnFacebookFriendsRequestComplete ??= FindFunction("Function WinDrv.FacebookWindows.OnFacebookFriendsRequestComplete");

        var @params = stackalloc byte[20];
        System.Buffer.MemoryCopy((void*)OriginalRequest.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy((void*)Response.Pointer, @params + 8, 8, 8);
        System.Buffer.MemoryCopy(&bDidSucceed, @params + 16, 4, 4);

        ProcessEvent(_ptrOnFacebookFriendsRequestComplete, @params);
    }

    // Function WinDrv.FacebookWindows.RequestFacebookFriends
    // 0x3750E0
    // (Final | Defined | Event | Private)
    public unsafe class RequestFacebookFriends_Parameters : BaseObject {
        public RequestFacebookFriends_Parameters() { }
        public RequestFacebookFriends_Parameters(nint pointer) : base(pointer) { }
    }
    private static UFunction _ptrRequestFacebookFriends;
    public void RequestFacebookFriends() {
        _ptrRequestFacebookFriends ??= FindFunction("Function WinDrv.FacebookWindows.RequestFacebookFriends");

        ProcessEvent(_ptrRequestFacebookFriends, null);
    }

    // Function WinDrv.FacebookWindows.OnFacebookMeRequestComplete
    // 0x3750E0
    // (Final | Defined | Private | HasDefaults)
    public unsafe class OnFacebookMeRequestComplete_Parameters : BaseObject {
        public OnFacebookMeRequestComplete_Parameters() { }
        public OnFacebookMeRequestComplete_Parameters(nint pointer) : base(pointer) { }

        // ObjectProperty WinDrv.FacebookWindows.OnFacebookMeRequestComplete.OriginalRequest
        // 0x0 (0x8)
        // (Param)
        public UHttpRequestInterface OriginalRequest {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }

        // ObjectProperty WinDrv.FacebookWindows.OnFacebookMeRequestComplete.Response
        // 0x8 (0x8)
        // (Param)
        public UHttpResponseInterface Response {
            get {
                var pointer = *(nint*)(Pointer + 8);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 8) = value.Pointer;
        }

        // BoolProperty WinDrv.FacebookWindows.OnFacebookMeRequestComplete.bDidSucceed
        // 0x10 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bDidSucceed {
            get => (*(uint*)(Pointer + 16) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 16) |= 0x1;
                else *(uint*)(Pointer + 16) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrOnFacebookMeRequestComplete;
    public void OnFacebookMeRequestComplete(UHttpRequestInterface OriginalRequest, UHttpResponseInterface Response, bool bDidSucceed) {
        _ptrOnFacebookMeRequestComplete ??= FindFunction("Function WinDrv.FacebookWindows.OnFacebookMeRequestComplete");

        var @params = stackalloc byte[20];
        System.Buffer.MemoryCopy((void*)OriginalRequest.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy((void*)Response.Pointer, @params + 8, 8, 8);
        System.Buffer.MemoryCopy(&bDidSucceed, @params + 16, 4, 4);

        ProcessEvent(_ptrOnFacebookMeRequestComplete, @params);
    }

    // Function WinDrv.FacebookWindows.RequestFacebookMeInfo
    // 0x3750E0
    // (Final | Defined | Event | Private)
    public unsafe class RequestFacebookMeInfo_Parameters : BaseObject {
        public RequestFacebookMeInfo_Parameters() { }
        public RequestFacebookMeInfo_Parameters(nint pointer) : base(pointer) { }
    }
    private static UFunction _ptrRequestFacebookMeInfo;
    public void RequestFacebookMeInfo() {
        _ptrRequestFacebookMeInfo ??= FindFunction("Function WinDrv.FacebookWindows.RequestFacebookMeInfo");

        ProcessEvent(_ptrRequestFacebookMeInfo, null);
    }

    // Function WinDrv.FacebookWindows.FacebookRequestCallback
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class FacebookRequestCallback_Parameters : BaseObject {
        public FacebookRequestCallback_Parameters() { }
        public FacebookRequestCallback_Parameters(nint pointer) : base(pointer) { }

        // ObjectProperty WinDrv.FacebookWindows.FacebookRequestCallback.OriginalRequest
        // 0x0 (0x8)
        // (Param)
        public UHttpRequestInterface OriginalRequest {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }

        // ObjectProperty WinDrv.FacebookWindows.FacebookRequestCallback.Response
        // 0x8 (0x8)
        // (Param)
        public UHttpResponseInterface Response {
            get {
                var pointer = *(nint*)(Pointer + 8);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 8) = value.Pointer;
        }

        // BoolProperty WinDrv.FacebookWindows.FacebookRequestCallback.bDidSucceed
        // 0x10 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bDidSucceed {
            get => (*(uint*)(Pointer + 16) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 16) |= 0x1;
                else *(uint*)(Pointer + 16) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrFacebookRequestCallback;
    public void FacebookRequestCallback(UHttpRequestInterface OriginalRequest, UHttpResponseInterface Response, bool bDidSucceed) {
        _ptrFacebookRequestCallback ??= FindFunction("Function WinDrv.FacebookWindows.FacebookRequestCallback");

        var @params = stackalloc byte[20];
        System.Buffer.MemoryCopy((void*)OriginalRequest.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy((void*)Response.Pointer, @params + 8, 8, 8);
        System.Buffer.MemoryCopy(&bDidSucceed, @params + 16, 4, 4);

        ProcessEvent(_ptrFacebookRequestCallback, @params);
    }

    // Function WinDrv.FacebookWindows.ProcessFacebookRequest
    // 0xD47F90
    // (Final | Native | Public)
    public unsafe class ProcessFacebookRequest_Parameters : BaseObject {
        public ProcessFacebookRequest_Parameters() { }
        public ProcessFacebookRequest_Parameters(nint pointer) : base(pointer) { }

        // StrProperty WinDrv.FacebookWindows.ProcessFacebookRequest.Payload
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Payload {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // IntProperty WinDrv.FacebookWindows.ProcessFacebookRequest.ResponseCode
        // 0x10 (0x4)
        // (Param)
        public int ResponseCode {
            get => *(int*)(Pointer + 16);
            set => *(int*)(Pointer + 16) = value;
        }
    }
    private static UFunction _ptrProcessFacebookRequest;
    public void ProcessFacebookRequest(FString Payload, int ResponseCode) {
        _ptrProcessFacebookRequest ??= FindFunction("Function WinDrv.FacebookWindows.ProcessFacebookRequest");

        var @params = stackalloc byte[20];
        System.Buffer.MemoryCopy((void*)Payload.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy(&ResponseCode, @params + 16, 4, 4);

        _ptrProcessFacebookRequest.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrProcessFacebookRequest, @params);
        _ptrProcessFacebookRequest.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function WinDrv.FacebookWindows.FacebookRequest
    // 0x3750E0
    // (Defined | HasOptionalParams | Public)
    public unsafe class FacebookRequest_Parameters : BaseObject {
        public FacebookRequest_Parameters() { }
        public FacebookRequest_Parameters(nint pointer) : base(pointer) { }

        // StrProperty WinDrv.FacebookWindows.FacebookRequest.GraphRequest
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString GraphRequest {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // StrProperty WinDrv.FacebookWindows.FacebookRequest.HTTPMethod
        // 0x10 (0x10)
        // (OptionalParam | Param | NeedCtorLink)
        public FString HTTPMethod {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 16, 16);
        }

        // ArrayProperty WinDrv.FacebookWindows.FacebookRequest.ParamKeysAndValues
        // 0x20 (0x10)
        // (OptionalParam | Param | NeedCtorLink)
        public StructTArray<FString> ParamKeysAndValues {
            get => new(Pointer + 32, 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 32), 16, 16);
        }
    }
    private static UFunction _ptrFacebookRequest;
    public void FacebookRequest(FString GraphRequest, FString HTTPMethod = null, StructTArray<FString> ParamKeysAndValues = null) {
        _ptrFacebookRequest ??= FindFunction("Function WinDrv.FacebookWindows.FacebookRequest");

        var @params = stackalloc byte[48];
        System.Buffer.MemoryCopy((void*)GraphRequest.Pointer, @params, 16, 16);
        if (HTTPMethod != null) System.Buffer.MemoryCopy((void*)HTTPMethod.Pointer, @params + 16, 16, 16);
        if (ParamKeysAndValues != null) System.Buffer.MemoryCopy((void*)ParamKeysAndValues.Pointer, @params + 32, 16, 16);

        ProcessEvent(_ptrFacebookRequest, @params);
    }

    // Function WinDrv.FacebookWindows.Disconnect
    // 0x67AB70
    // (Native | Public)
    public unsafe class Disconnect_Parameters : BaseObject {
        public Disconnect_Parameters() { }
        public Disconnect_Parameters(nint pointer) : base(pointer) { }
    }
    private static UFunction _ptrDisconnect;
    public void Disconnect() {
        _ptrDisconnect ??= FindFunction("Function WinDrv.FacebookWindows.Disconnect");

        _ptrDisconnect.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrDisconnect, null);
        _ptrDisconnect.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function WinDrv.FacebookWindows.IsAuthorized
    // 0x665500
    // (Native | Public)
    public unsafe class IsAuthorized_Parameters : BaseObject {
        public IsAuthorized_Parameters() { }
        public IsAuthorized_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty WinDrv.FacebookWindows.IsAuthorized.ReturnValue
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrIsAuthorized;
    public bool IsAuthorized() {
        _ptrIsAuthorized ??= FindFunction("Function WinDrv.FacebookWindows.IsAuthorized");

        var @params = stackalloc byte[4];

        _ptrIsAuthorized.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrIsAuthorized, @params);
        _ptrIsAuthorized.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)@params;
    }

    // Function WinDrv.FacebookWindows.Authorize
    // 0x67A500
    // (Native | Public)
    public unsafe class Authorize_Parameters : BaseObject {
        public Authorize_Parameters() { }
        public Authorize_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty WinDrv.FacebookWindows.Authorize.ReturnValue
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrAuthorize;
    public bool Authorize() {
        _ptrAuthorize ??= FindFunction("Function WinDrv.FacebookWindows.Authorize");

        var @params = stackalloc byte[4];

        _ptrAuthorize.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrAuthorize, @params);
        _ptrAuthorize.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)@params;
    }

    // Function WinDrv.FacebookWindows.Init
    // 0x659230
    // (Native | Public)
    public unsafe class Init_Parameters : BaseObject {
        public Init_Parameters() { }
        public Init_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty WinDrv.FacebookWindows.Init.ReturnValue
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrInit;
    public bool Init() {
        _ptrInit ??= FindFunction("Function WinDrv.FacebookWindows.Init");

        var @params = stackalloc byte[4];

        _ptrInit.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrInit, @params);
        _ptrInit.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)@params;
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class WinDrv.FacebookWindows");
            return _staticClass;
        }
    }
}

// Class WinDrv.HttpRequestWindows
// 0x30 (0x78 - 0xA8)
// (Compiled | Parsed | Native)
public unsafe partial class UHttpRequestWindows : UHttpRequestInterface {
    public UHttpRequestWindows() { }
    public UHttpRequestWindows(nint pointer) : base(pointer) { }


    // StructProperty WinDrv.HttpRequestWindows.Request
    // 0x78 (0x8)
    // (Const | Native | Transient)
    public nint Request {
        get => *(nint*)(Pointer + 120);
        set => *(nint*)(Pointer + 120) = value;
    }

    // StrProperty WinDrv.HttpRequestWindows.RequestVerb
    // 0x80 (0x10)
    // (Const | Native)
    public FString RequestVerb {
        get => new(Pointer + 128);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 128), 16, 16);
    }

    // StructProperty WinDrv.HttpRequestWindows.RequestURL
    // 0x90 (0x8)
    // (Const | Native | Transient)
    public nint RequestURL {
        get => *(nint*)(Pointer + 144);
        set => *(nint*)(Pointer + 144) = value;
    }

    // ArrayProperty WinDrv.HttpRequestWindows.Payload
    // 0x98 (0x10)
    // (Const | Native)
    public UnmanagedTArray<byte> Payload {
        get => new(Pointer + 152);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 152), 16, 16);
    }


    // Function WinDrv.HttpRequestWindows.ProcessRequest
    // 0x67EF80
    // (Native | Public)
    public unsafe class ProcessRequest_Parameters : BaseObject {
        public ProcessRequest_Parameters() { }
        public ProcessRequest_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty WinDrv.HttpRequestWindows.ProcessRequest.ReturnValue
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrProcessRequest;
    public bool ProcessRequest() {
        _ptrProcessRequest ??= FindFunction("Function WinDrv.HttpRequestWindows.ProcessRequest");

        var @params = stackalloc byte[4];

        _ptrProcessRequest.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrProcessRequest, @params);
        _ptrProcessRequest.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)@params;
    }

    // Function WinDrv.HttpRequestWindows.SetHeader
    // 0x67EDE0
    // (Native | Public)
    public unsafe class SetHeader_Parameters : BaseObject {
        public SetHeader_Parameters() { }
        public SetHeader_Parameters(nint pointer) : base(pointer) { }

        // StrProperty WinDrv.HttpRequestWindows.SetHeader.HeaderName
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString HeaderName {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // StrProperty WinDrv.HttpRequestWindows.SetHeader.HeaderValue
        // 0x10 (0x10)
        // (Param | NeedCtorLink)
        public FString HeaderValue {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 16, 16);
        }

        // ObjectProperty WinDrv.HttpRequestWindows.SetHeader.ReturnValue
        // 0x20 (0x8)
        // (Param | OutParam | ReturnParam)
        public UHttpRequestInterface ReturnValue {
            get {
                var pointer = *(nint*)(Pointer + 32);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 32) = value.Pointer;
        }
    }
    private static UFunction _ptrSetHeader;
    public UHttpRequestInterface SetHeader(FString HeaderName, FString HeaderValue) {
        _ptrSetHeader ??= FindFunction("Function WinDrv.HttpRequestWindows.SetHeader");

        var @params = stackalloc byte[40];
        System.Buffer.MemoryCopy((void*)HeaderName.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy((void*)HeaderValue.Pointer, @params + 16, 16, 16);

        _ptrSetHeader.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetHeader, @params);
        _ptrSetHeader.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return new(*(nint*)(@params + 32));
    }

    // Function WinDrv.HttpRequestWindows.SetContentAsString
    // 0x67EC30
    // (Native | Public)
    public unsafe class SetContentAsString_Parameters : BaseObject {
        public SetContentAsString_Parameters() { }
        public SetContentAsString_Parameters(nint pointer) : base(pointer) { }

        // StrProperty WinDrv.HttpRequestWindows.SetContentAsString.ContentString
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString ContentString {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // ObjectProperty WinDrv.HttpRequestWindows.SetContentAsString.ReturnValue
        // 0x10 (0x8)
        // (Param | OutParam | ReturnParam)
        public UHttpRequestInterface ReturnValue {
            get {
                var pointer = *(nint*)(Pointer + 16);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 16) = value.Pointer;
        }
    }
    private static UFunction _ptrSetContentAsString;
    public UHttpRequestInterface SetContentAsString(FString ContentString) {
        _ptrSetContentAsString ??= FindFunction("Function WinDrv.HttpRequestWindows.SetContentAsString");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)ContentString.Pointer, @params, 16, 16);

        _ptrSetContentAsString.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetContentAsString, @params);
        _ptrSetContentAsString.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return new(*(nint*)(@params + 16));
    }

    // Function WinDrv.HttpRequestWindows.SetContent
    // 0x67EAB0
    // (Native | Public | HasOutParams)
    public unsafe class SetContent_Parameters : BaseObject {
        public SetContent_Parameters() { }
        public SetContent_Parameters(nint pointer) : base(pointer) { }

        // ArrayProperty WinDrv.HttpRequestWindows.SetContent.ContentPayload
        // 0x0 (0x10)
        // (Const | Param | OutParam | NeedCtorLink)
        public UnmanagedTArray<byte> ContentPayload {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // ObjectProperty WinDrv.HttpRequestWindows.SetContent.ReturnValue
        // 0x10 (0x8)
        // (Param | OutParam | ReturnParam)
        public UHttpRequestInterface ReturnValue {
            get {
                var pointer = *(nint*)(Pointer + 16);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 16) = value.Pointer;
        }
    }
    private static UFunction _ptrSetContent;
    public UHttpRequestInterface SetContent(ref UnmanagedTArray<byte> ContentPayload) {
        _ptrSetContent ??= FindFunction("Function WinDrv.HttpRequestWindows.SetContent");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)ContentPayload.Pointer, @params, 16, 16);

        _ptrSetContent.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetContent, @params);
        _ptrSetContent.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _ContentPayloadPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params, (void*)_ContentPayloadPtr, 16, 16);
        ContentPayload = new(_ContentPayloadPtr) { Allocated = true };

        return new(*(nint*)(@params + 16));
    }

    // Function WinDrv.HttpRequestWindows.SetURL
    // 0x67E900
    // (Native | Public)
    public unsafe class SetURL_Parameters : BaseObject {
        public SetURL_Parameters() { }
        public SetURL_Parameters(nint pointer) : base(pointer) { }

        // StrProperty WinDrv.HttpRequestWindows.SetURL.URL
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString URL {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // ObjectProperty WinDrv.HttpRequestWindows.SetURL.ReturnValue
        // 0x10 (0x8)
        // (Param | OutParam | ReturnParam)
        public UHttpRequestInterface ReturnValue {
            get {
                var pointer = *(nint*)(Pointer + 16);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 16) = value.Pointer;
        }
    }
    private static UFunction _ptrSetURL;
    public UHttpRequestInterface SetURL(FString URL) {
        _ptrSetURL ??= FindFunction("Function WinDrv.HttpRequestWindows.SetURL");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)URL.Pointer, @params, 16, 16);

        _ptrSetURL.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetURL, @params);
        _ptrSetURL.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return new(*(nint*)(@params + 16));
    }

    // Function WinDrv.HttpRequestWindows.SetVerb
    // 0x67E840
    // (Native | Public)
    public unsafe class SetVerb_Parameters : BaseObject {
        public SetVerb_Parameters() { }
        public SetVerb_Parameters(nint pointer) : base(pointer) { }

        // StrProperty WinDrv.HttpRequestWindows.SetVerb.Verb
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Verb {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // ObjectProperty WinDrv.HttpRequestWindows.SetVerb.ReturnValue
        // 0x10 (0x8)
        // (Param | OutParam | ReturnParam)
        public UHttpRequestInterface ReturnValue {
            get {
                var pointer = *(nint*)(Pointer + 16);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 16) = value.Pointer;
        }
    }
    private static UFunction _ptrSetVerb;
    public UHttpRequestInterface SetVerb(FString Verb) {
        _ptrSetVerb ??= FindFunction("Function WinDrv.HttpRequestWindows.SetVerb");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)Verb.Pointer, @params, 16, 16);

        _ptrSetVerb.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetVerb, @params);
        _ptrSetVerb.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return new(*(nint*)(@params + 16));
    }

    // Function WinDrv.HttpRequestWindows.GetVerb
    // 0x67E790
    // (Native | Public)
    public unsafe class GetVerb_Parameters : BaseObject {
        public GetVerb_Parameters() { }
        public GetVerb_Parameters(nint pointer) : base(pointer) { }

        // StrProperty WinDrv.HttpRequestWindows.GetVerb.ReturnValue
        // 0x0 (0x10)
        // (Param | OutParam | ReturnParam | NeedCtorLink)
        public FString ReturnValue {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }
    }
    private static UFunction _ptrGetVerb;
    public FString GetVerb() {
        _ptrGetVerb ??= FindFunction("Function WinDrv.HttpRequestWindows.GetVerb");

        var @params = stackalloc byte[16];

        _ptrGetVerb.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetVerb, @params);
        _ptrGetVerb.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _ReturnValuePtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params, (void*)_ReturnValuePtr, 16, 16);
        return new(_ReturnValuePtr) { Allocated = true };
    }

    // Function WinDrv.HttpRequestWindows.GetContent
    // 0x67CC80
    // (Native | Public | HasOutParams)
    public unsafe class GetContent_Parameters : BaseObject {
        public GetContent_Parameters() { }
        public GetContent_Parameters(nint pointer) : base(pointer) { }

        // ArrayProperty WinDrv.HttpRequestWindows.GetContent.Content
        // 0x0 (0x10)
        // (Param | OutParam | NeedCtorLink)
        public UnmanagedTArray<byte> Content {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }
    }
    private static UFunction _ptrGetContent;
    public void GetContent(ref UnmanagedTArray<byte> Content) {
        _ptrGetContent ??= FindFunction("Function WinDrv.HttpRequestWindows.GetContent");

        var @params = stackalloc byte[16];
        System.Buffer.MemoryCopy((void*)Content.Pointer, @params, 16, 16);

        _ptrGetContent.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetContent, @params);
        _ptrGetContent.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _ContentPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params, (void*)_ContentPtr, 16, 16);
        Content = new(_ContentPtr) { Allocated = true };
    }

    // Function WinDrv.HttpRequestWindows.GetURL
    // 0x67CBD0
    // (Native | Public)
    public unsafe class GetURL_Parameters : BaseObject {
        public GetURL_Parameters() { }
        public GetURL_Parameters(nint pointer) : base(pointer) { }

        // StrProperty WinDrv.HttpRequestWindows.GetURL.ReturnValue
        // 0x0 (0x10)
        // (Param | OutParam | ReturnParam | NeedCtorLink)
        public FString ReturnValue {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }
    }
    private static UFunction _ptrGetURL;
    public FString GetURL() {
        _ptrGetURL ??= FindFunction("Function WinDrv.HttpRequestWindows.GetURL");

        var @params = stackalloc byte[16];

        _ptrGetURL.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetURL, @params);
        _ptrGetURL.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _ReturnValuePtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params, (void*)_ReturnValuePtr, 16, 16);
        return new(_ReturnValuePtr) { Allocated = true };
    }

    // Function WinDrv.HttpRequestWindows.GetContentLength
    // 0x67CB80
    // (Native | Public)
    public unsafe class GetContentLength_Parameters : BaseObject {
        public GetContentLength_Parameters() { }
        public GetContentLength_Parameters(nint pointer) : base(pointer) { }

        // IntProperty WinDrv.HttpRequestWindows.GetContentLength.ReturnValue
        // 0x0 (0x4)
        // (Param | OutParam | ReturnParam)
        public int ReturnValue {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }
    }
    private static UFunction _ptrGetContentLength;
    public int GetContentLength() {
        _ptrGetContentLength ??= FindFunction("Function WinDrv.HttpRequestWindows.GetContentLength");

        var @params = stackalloc byte[4];

        _ptrGetContentLength.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetContentLength, @params);
        _ptrGetContentLength.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(int*)@params;
    }

    // Function WinDrv.HttpRequestWindows.GetContentType
    // 0x67CAD0
    // (Native | Public)
    public unsafe class GetContentType_Parameters : BaseObject {
        public GetContentType_Parameters() { }
        public GetContentType_Parameters(nint pointer) : base(pointer) { }

        // StrProperty WinDrv.HttpRequestWindows.GetContentType.ReturnValue
        // 0x0 (0x10)
        // (Param | OutParam | ReturnParam | NeedCtorLink)
        public FString ReturnValue {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }
    }
    private static UFunction _ptrGetContentType;
    public FString GetContentType() {
        _ptrGetContentType ??= FindFunction("Function WinDrv.HttpRequestWindows.GetContentType");

        var @params = stackalloc byte[16];

        _ptrGetContentType.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetContentType, @params);
        _ptrGetContentType.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _ReturnValuePtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params, (void*)_ReturnValuePtr, 16, 16);
        return new(_ReturnValuePtr) { Allocated = true };
    }

    // Function WinDrv.HttpRequestWindows.GetURLParameter
    // 0x67C9C0
    // (Native | Public)
    public unsafe class GetURLParameter_Parameters : BaseObject {
        public GetURLParameter_Parameters() { }
        public GetURLParameter_Parameters(nint pointer) : base(pointer) { }

        // StrProperty WinDrv.HttpRequestWindows.GetURLParameter.ParameterName
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString ParameterName {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // StrProperty WinDrv.HttpRequestWindows.GetURLParameter.ReturnValue
        // 0x10 (0x10)
        // (Param | OutParam | ReturnParam | NeedCtorLink)
        public FString ReturnValue {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 16, 16);
        }
    }
    private static UFunction _ptrGetURLParameter;
    public FString GetURLParameter(FString ParameterName) {
        _ptrGetURLParameter ??= FindFunction("Function WinDrv.HttpRequestWindows.GetURLParameter");

        var @params = stackalloc byte[32];
        System.Buffer.MemoryCopy((void*)ParameterName.Pointer, @params, 16, 16);

        _ptrGetURLParameter.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetURLParameter, @params);
        _ptrGetURLParameter.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _ReturnValuePtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 16, (void*)_ReturnValuePtr, 16, 16);
        return new(_ReturnValuePtr) { Allocated = true };
    }

    // Function WinDrv.HttpRequestWindows.GetHeaders
    // 0x67C8F0
    // (Native | Public)
    public unsafe class GetHeaders_Parameters : BaseObject {
        public GetHeaders_Parameters() { }
        public GetHeaders_Parameters(nint pointer) : base(pointer) { }

        // ArrayProperty WinDrv.HttpRequestWindows.GetHeaders.ReturnValue
        // 0x0 (0x10)
        // (Param | OutParam | ReturnParam | NeedCtorLink)
        public StructTArray<FString> ReturnValue {
            get => new(Pointer, 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }
    }
    private static UFunction _ptrGetHeaders;
    public StructTArray<FString> GetHeaders() {
        _ptrGetHeaders ??= FindFunction("Function WinDrv.HttpRequestWindows.GetHeaders");

        var @params = stackalloc byte[16];

        _ptrGetHeaders.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetHeaders, @params);
        _ptrGetHeaders.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _ReturnValuePtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params, (void*)_ReturnValuePtr, 16, 16);
        return new(_ReturnValuePtr, 16) { Allocated = true };
    }

    // Function WinDrv.HttpRequestWindows.GetHeader
    // 0x67C7E0
    // (Native | Public)
    public unsafe class GetHeader_Parameters : BaseObject {
        public GetHeader_Parameters() { }
        public GetHeader_Parameters(nint pointer) : base(pointer) { }

        // StrProperty WinDrv.HttpRequestWindows.GetHeader.HeaderName
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString HeaderName {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // StrProperty WinDrv.HttpRequestWindows.GetHeader.ReturnValue
        // 0x10 (0x10)
        // (Param | OutParam | ReturnParam | NeedCtorLink)
        public FString ReturnValue {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 16, 16);
        }
    }
    private static UFunction _ptrGetHeader;
    public FString GetHeader(FString HeaderName) {
        _ptrGetHeader ??= FindFunction("Function WinDrv.HttpRequestWindows.GetHeader");

        var @params = stackalloc byte[32];
        System.Buffer.MemoryCopy((void*)HeaderName.Pointer, @params, 16, 16);

        _ptrGetHeader.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetHeader, @params);
        _ptrGetHeader.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _ReturnValuePtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 16, (void*)_ReturnValuePtr, 16, 16);
        return new(_ReturnValuePtr) { Allocated = true };
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class WinDrv.HttpRequestWindows");
            return _staticClass;
        }
    }
}

// Class WinDrv.HttpResponseWindows
// 0x18 (0x60 - 0x78)
// (Compiled | Parsed | Native)
public unsafe partial class UHttpResponseWindows : UHttpResponseInterface {
    public UHttpResponseWindows() { }
    public UHttpResponseWindows(nint pointer) : base(pointer) { }


    // StructProperty WinDrv.HttpResponseWindows.Response
    // 0x60 (0x8)
    // (Const | Native | Transient)
    public nint Response {
        get => *(nint*)(Pointer + 96);
        set => *(nint*)(Pointer + 96) = value;
    }

    // ArrayProperty WinDrv.HttpResponseWindows.Payload
    // 0x68 (0x10)
    // (Const | Native)
    public UnmanagedTArray<byte> Payload {
        get => new(Pointer + 104);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 104), 16, 16);
    }


    // Function WinDrv.HttpResponseWindows.GetResponseCode
    // 0x6806D0
    // (Native | Public)
    public unsafe class GetResponseCode_Parameters : BaseObject {
        public GetResponseCode_Parameters() { }
        public GetResponseCode_Parameters(nint pointer) : base(pointer) { }

        // IntProperty WinDrv.HttpResponseWindows.GetResponseCode.ReturnValue
        // 0x0 (0x4)
        // (Param | OutParam | ReturnParam)
        public int ReturnValue {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }
    }
    private static UFunction _ptrGetResponseCode;
    public int GetResponseCode() {
        _ptrGetResponseCode ??= FindFunction("Function WinDrv.HttpResponseWindows.GetResponseCode");

        var @params = stackalloc byte[4];

        _ptrGetResponseCode.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetResponseCode, @params);
        _ptrGetResponseCode.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(int*)@params;
    }

    // Function WinDrv.HttpResponseWindows.GetContentAsString
    // 0x680720
    // (Native | Public)
    public unsafe class GetContentAsString_Parameters : BaseObject {
        public GetContentAsString_Parameters() { }
        public GetContentAsString_Parameters(nint pointer) : base(pointer) { }

        // StrProperty WinDrv.HttpResponseWindows.GetContentAsString.ReturnValue
        // 0x0 (0x10)
        // (Param | OutParam | ReturnParam | NeedCtorLink)
        public FString ReturnValue {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }
    }
    private static UFunction _ptrGetContentAsString;
    public FString GetContentAsString() {
        _ptrGetContentAsString ??= FindFunction("Function WinDrv.HttpResponseWindows.GetContentAsString");

        var @params = stackalloc byte[16];

        _ptrGetContentAsString.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetContentAsString, @params);
        _ptrGetContentAsString.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _ReturnValuePtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params, (void*)_ReturnValuePtr, 16, 16);
        return new(_ReturnValuePtr) { Allocated = true };
    }

    // Function WinDrv.HttpResponseWindows.GetContent
    // 0x67CC80
    // (Native | Public | HasOutParams)
    public unsafe class GetContent_Parameters : BaseObject {
        public GetContent_Parameters() { }
        public GetContent_Parameters(nint pointer) : base(pointer) { }

        // ArrayProperty WinDrv.HttpResponseWindows.GetContent.Content
        // 0x0 (0x10)
        // (Param | OutParam | NeedCtorLink)
        public UnmanagedTArray<byte> Content {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }
    }
    private static UFunction _ptrGetContent;
    public void GetContent(ref UnmanagedTArray<byte> Content) {
        _ptrGetContent ??= FindFunction("Function WinDrv.HttpResponseWindows.GetContent");

        var @params = stackalloc byte[16];
        System.Buffer.MemoryCopy((void*)Content.Pointer, @params, 16, 16);

        _ptrGetContent.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetContent, @params);
        _ptrGetContent.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _ContentPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params, (void*)_ContentPtr, 16, 16);
        Content = new(_ContentPtr) { Allocated = true };
    }

    // Function WinDrv.HttpResponseWindows.GetURL
    // 0x67CBD0
    // (Native | Public)
    public unsafe class GetURL_Parameters : BaseObject {
        public GetURL_Parameters() { }
        public GetURL_Parameters(nint pointer) : base(pointer) { }

        // StrProperty WinDrv.HttpResponseWindows.GetURL.ReturnValue
        // 0x0 (0x10)
        // (Param | OutParam | ReturnParam | NeedCtorLink)
        public FString ReturnValue {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }
    }
    private static UFunction _ptrGetURL;
    public FString GetURL() {
        _ptrGetURL ??= FindFunction("Function WinDrv.HttpResponseWindows.GetURL");

        var @params = stackalloc byte[16];

        _ptrGetURL.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetURL, @params);
        _ptrGetURL.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _ReturnValuePtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params, (void*)_ReturnValuePtr, 16, 16);
        return new(_ReturnValuePtr) { Allocated = true };
    }

    // Function WinDrv.HttpResponseWindows.GetContentLength
    // 0x67CB80
    // (Native | Public)
    public unsafe class GetContentLength_Parameters : BaseObject {
        public GetContentLength_Parameters() { }
        public GetContentLength_Parameters(nint pointer) : base(pointer) { }

        // IntProperty WinDrv.HttpResponseWindows.GetContentLength.ReturnValue
        // 0x0 (0x4)
        // (Param | OutParam | ReturnParam)
        public int ReturnValue {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }
    }
    private static UFunction _ptrGetContentLength;
    public int GetContentLength() {
        _ptrGetContentLength ??= FindFunction("Function WinDrv.HttpResponseWindows.GetContentLength");

        var @params = stackalloc byte[4];

        _ptrGetContentLength.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetContentLength, @params);
        _ptrGetContentLength.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(int*)@params;
    }

    // Function WinDrv.HttpResponseWindows.GetContentType
    // 0x67CAD0
    // (Native | Public)
    public unsafe class GetContentType_Parameters : BaseObject {
        public GetContentType_Parameters() { }
        public GetContentType_Parameters(nint pointer) : base(pointer) { }

        // StrProperty WinDrv.HttpResponseWindows.GetContentType.ReturnValue
        // 0x0 (0x10)
        // (Param | OutParam | ReturnParam | NeedCtorLink)
        public FString ReturnValue {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }
    }
    private static UFunction _ptrGetContentType;
    public FString GetContentType() {
        _ptrGetContentType ??= FindFunction("Function WinDrv.HttpResponseWindows.GetContentType");

        var @params = stackalloc byte[16];

        _ptrGetContentType.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetContentType, @params);
        _ptrGetContentType.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _ReturnValuePtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params, (void*)_ReturnValuePtr, 16, 16);
        return new(_ReturnValuePtr) { Allocated = true };
    }

    // Function WinDrv.HttpResponseWindows.GetURLParameter
    // 0x67C9C0
    // (Native | Public)
    public unsafe class GetURLParameter_Parameters : BaseObject {
        public GetURLParameter_Parameters() { }
        public GetURLParameter_Parameters(nint pointer) : base(pointer) { }

        // StrProperty WinDrv.HttpResponseWindows.GetURLParameter.ParameterName
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString ParameterName {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // StrProperty WinDrv.HttpResponseWindows.GetURLParameter.ReturnValue
        // 0x10 (0x10)
        // (Param | OutParam | ReturnParam | NeedCtorLink)
        public FString ReturnValue {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 16, 16);
        }
    }
    private static UFunction _ptrGetURLParameter;
    public FString GetURLParameter(FString ParameterName) {
        _ptrGetURLParameter ??= FindFunction("Function WinDrv.HttpResponseWindows.GetURLParameter");

        var @params = stackalloc byte[32];
        System.Buffer.MemoryCopy((void*)ParameterName.Pointer, @params, 16, 16);

        _ptrGetURLParameter.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetURLParameter, @params);
        _ptrGetURLParameter.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _ReturnValuePtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 16, (void*)_ReturnValuePtr, 16, 16);
        return new(_ReturnValuePtr) { Allocated = true };
    }

    // Function WinDrv.HttpResponseWindows.GetHeaders
    // 0x67C8F0
    // (Native | Public)
    public unsafe class GetHeaders_Parameters : BaseObject {
        public GetHeaders_Parameters() { }
        public GetHeaders_Parameters(nint pointer) : base(pointer) { }

        // ArrayProperty WinDrv.HttpResponseWindows.GetHeaders.ReturnValue
        // 0x0 (0x10)
        // (Param | OutParam | ReturnParam | NeedCtorLink)
        public StructTArray<FString> ReturnValue {
            get => new(Pointer, 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }
    }
    private static UFunction _ptrGetHeaders;
    public StructTArray<FString> GetHeaders() {
        _ptrGetHeaders ??= FindFunction("Function WinDrv.HttpResponseWindows.GetHeaders");

        var @params = stackalloc byte[16];

        _ptrGetHeaders.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetHeaders, @params);
        _ptrGetHeaders.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _ReturnValuePtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params, (void*)_ReturnValuePtr, 16, 16);
        return new(_ReturnValuePtr, 16) { Allocated = true };
    }

    // Function WinDrv.HttpResponseWindows.GetHeader
    // 0x67C7E0
    // (Native | Public)
    public unsafe class GetHeader_Parameters : BaseObject {
        public GetHeader_Parameters() { }
        public GetHeader_Parameters(nint pointer) : base(pointer) { }

        // StrProperty WinDrv.HttpResponseWindows.GetHeader.HeaderName
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString HeaderName {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // StrProperty WinDrv.HttpResponseWindows.GetHeader.ReturnValue
        // 0x10 (0x10)
        // (Param | OutParam | ReturnParam | NeedCtorLink)
        public FString ReturnValue {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 16, 16);
        }
    }
    private static UFunction _ptrGetHeader;
    public FString GetHeader(FString HeaderName) {
        _ptrGetHeader ??= FindFunction("Function WinDrv.HttpResponseWindows.GetHeader");

        var @params = stackalloc byte[32];
        System.Buffer.MemoryCopy((void*)HeaderName.Pointer, @params, 16, 16);

        _ptrGetHeader.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetHeader, @params);
        _ptrGetHeader.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _ReturnValuePtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 16, (void*)_ReturnValuePtr, 16, 16);
        return new(_ReturnValuePtr) { Allocated = true };
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class WinDrv.HttpResponseWindows");
            return _staticClass;
        }
    }
}

// Class WinDrv.WindowsClient
// 0x348 (0x78 - 0x3C0)
// (Config | Transient | Native | Intrinsic)
public unsafe partial class UWindowsClient : UClient {
    public UWindowsClient() { }
    public UWindowsClient(nint pointer) : base(pointer) { }


    // MISSED OFFSET: 0x200

    // ClassProperty WinDrv.WindowsClient.AudioDeviceClass
    // 0x278 (0x8)
    // (Config)
    public UClass AudioDeviceClass {
        get {
            var pointer = *(nint*)(Pointer + 632);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 632) = value.Pointer;
    }

    // MISSED OFFSET: 0x38

    // IntProperty WinDrv.WindowsClient.AllowJoystickInput
    // 0x2B8 (0x4)
    // (Config)
    public int AllowJoystickInput {
        get => *(int*)(Pointer + 696);
        set => *(int*)(Pointer + 696) = value;
    }

    // MISSED OFFSET: 0x104


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class WinDrv.WindowsClient");
            return _staticClass;
        }
    }
}

// Class WinDrv.XnaForceFeedbackManager
// 0x18 (0x98 - 0xB0)
// (Config | Transient | Native | Intrinsic)
public unsafe partial class UXnaForceFeedbackManager : UForceFeedbackManager {
    public UXnaForceFeedbackManager() { }
    public UXnaForceFeedbackManager(nint pointer) : base(pointer) { }


    // MISSED OFFSET: 0x18


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class WinDrv.XnaForceFeedbackManager");
            return _staticClass;
        }
    }
}

// Class WinDrv.HttpRequestWindowsMcp
// 0x20 (0xA8 - 0xC8)
// (Compiled | Config | Parsed)
public unsafe partial class UHttpRequestWindowsMcp : UHttpRequestWindows {
    public UHttpRequestWindowsMcp() { }
    public UHttpRequestWindowsMcp(nint pointer) : base(pointer) { }


    // StrProperty WinDrv.HttpRequestWindowsMcp.AppID
    // 0xA8 (0x10)
    // (Const | Config | NeedCtorLink)
    public FString AppID {
        get => new(Pointer + 168);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 168), 16, 16);
    }

    // StrProperty WinDrv.HttpRequestWindowsMcp.AppSecret
    // 0xB8 (0x10)
    // (Const | Config | NeedCtorLink)
    public FString AppSecret {
        get => new(Pointer + 184);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 184), 16, 16);
    }


    // Function WinDrv.HttpRequestWindowsMcp.ProcessRequest
    // 0x3750E0
    // (Defined | Public)
    public unsafe class ProcessRequest_Parameters : BaseObject {
        public ProcessRequest_Parameters() { }
        public ProcessRequest_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty WinDrv.HttpRequestWindowsMcp.ProcessRequest.ReturnValue
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrProcessRequest;
    public bool ProcessRequest() {
        _ptrProcessRequest ??= FindFunction("Function WinDrv.HttpRequestWindowsMcp.ProcessRequest");

        var @params = stackalloc byte[4];

        ProcessEvent(_ptrProcessRequest, @params);

        return *(bool*)@params;
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class WinDrv.HttpRequestWindowsMcp");
            return _staticClass;
        }
    }
}

#pragma warning restore CS0108, CS0114
