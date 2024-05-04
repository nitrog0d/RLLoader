namespace RLDumper.Core.Classes;

public static class Flags {
    [Flags]
    public enum EFunctionFlags : ulong {
        Final = 0x00000001,	// Function is final (prebindable, non-overridable function).
        Defined = 0x00000002, // Function has been defined (not just declared).
        Iterator = 0x00000004, // Function is an iterator.
        Latent = 0x00000008, // Function is a latent state function.
        PreOperator = 0x00000010, // Unary operator is a prefix operator.
        Singular = 0x00000020, // Function cannot be reentered.
        Net = 0x00000040, // Function is network-replicated.
        NetReliable = 0x00000080, // Function should be sent reliably on the network.
        Simulated = 0x00000100, // Function executed on the client side.
        Exec = 0x00000200, // Executable from command line.
        Native = 0x00000400, // Native function.
        Event = 0x00000800, // Event function.
        Operator = 0x00001000, // Operator function.
        Static = 0x00002000, // Static function.
        HasOptionalParams = 0x00004000, // Function has optional parameters
        Const = 0x00008000, // Function doesn't modify this object.
        Invariant = 0x00010000,
        Public = 0x00020000, // Function is accessible in all classes (if overridden, parameters much remain unchanged).
        Private = 0x00040000, // Function is accessible only in the class it is defined in (cannot be overriden, but function name may be reused in subclasses. IOW: if overridden, parameters don't need to match, and Super.Func() cannot be accessed since it's private.)
        Protected = 0x00080000, // Function is accessible only in the class it is defined in and subclasses (if overridden, parameters much remain unchanged).
        Delegate = 0x00100000, // Function is actually a delegate.
        NetServer = 0x00200000, // Function is executed on servers (set by replication code if passes check)
        HasOutParams = 0x00400000, // function has out (pass by reference) parameters
        HasDefaults = 0x00800000, // function has structs that contain defaults
        NetClient = 0x01000000, // function is executed on clients
        DLLImport = 0x02000000, // function is imported from a DLL
        K2Call = 0x04000000,
        K2Override = 0x08000000,
        K2Pure = 0x10000000,
        EditorOnly = 0x20000000,
        Lambda = 0x40000000,
        NetValidate = 0x80000000
    };

    [Flags]
    public enum EPropertyFlags : ulong {
        Edit = 0x0000000000000001,  // Property is user-settable in the editor.
        Const = 0x0000000000000002, // Actor's property always matches class's default actor property.
        Input = 0x0000000000000004, // Variable is writable by the input system.
        ExportObject = 0x0000000000000008,  // Object can be exported with actor.
        OptionalParam = 0x0000000000000010,  // Optional parameter (if Param is set).
        Net = 0x0000000000000020,   // Property is relevant to network replication.
        EditFixedSize = 0x0000000000000040,    // Indicates that elements of an array can be modified, but its size cannot be changed.
        Param = 0x0000000000000080,  // Function/When call parameter.
        OutParam = 0x0000000000000100,   // Value is copied out after function call.
        SkipParam = 0x0000000000000200,  // Property is a short-circuitable evaluation function parm.
        ReturnParam = 0x0000000000000400,    // Return value.
        CoerceParam = 0x0000000000000800,    // Coerce args into this function parameter.
        Native = 0x0000000000001000,    // Property is native: C++ code is responsible for serializing it.
        Transient = 0x0000000000002000, // Property is transient: shouldn't be saved, zero-filled at load time.
        Config = 0x0000000000004000,    // Property should be loaded/saved as permanent profile.
        Localized = 0x0000000000008000, // Property should be loaded as localizable text.

        Travel = 0x0000000000010000,    // Property travels across levels/servers.
        EditConst = 0x0000000000020000, // Property is uneditable in the editor.
        GlobalConfig = 0x0000000000040000,  // Load config from base class, not subclass.
        Component = 0x0000000000080000, // Property containts component references.
        AlwaysInit = 0x0000000000100000, // Property should never be exported as NoInit	(@todo - this doesn't need to be a property flag...only used during make)
        DuplicateTransient = 0x0000000000200000, // Property should always be reset to the default value during any type of duplication (copy/paste, binary duplication, etc.)
        NeedCtorLink = 0x0000000000400000,  // Fields need construction/destruction.
        NoExport = 0x0000000000800000,  // Property should not be exported to the native class header file.
        NoImport = 0x0000000001000000, // // Property should not be imported when creating an object from text (copy/paste)
        NoClear = 0x0000000002000000,   // Hide clear (and browse) button.
        EditInline = 0x0000000004000000,    // Edit this object reference inline.
        EdFindable = 0x0000000008000000,    // References are set by clicking on actors in the editor viewports.

        EditInlineUse = 0x0000000010000000, // EditInline with Use button.
        Deprecated = 0x0000000020000000,    // Property is deprecated.  Read it from an archive, but don't save it.
        DataBinding = 0x0000000040000000,  // Indicates that this property should be exposed to data stores
        SerializeText = 0x0000000080000000,  // Native property should be serialized as text (ImportText, ExportText)

        RepNotify = 0x0000000100000000, // Notify actors when a property is replicated
        Interp = 0x0000000200000000,    // interpolatable property for use with matinee
        NonTransactional = 0x0000000400000000,  // Property isn't transacted

        EditorOnly = 0x0000000800000000,    // Property should only be loaded in the editor.
        NotForConsole = 0x0000001000000000,		// Property should not be loaded on console (or be a console cooker commandlet)
        RepRetry = 0x0000002000000000,		// retry replication of this property if it fails to be fully sent (e.g. object references not yet available to serialize over the network)
        PrivateWrite = 0x0000004000000000,		// property is const outside of the class it was declared in
        ProtectedWrite = 0x0000008000000000,		// property is const outside of the class it was declared in and subclasses

        ArchetypeProperty = 0x0000010000000000,		// property should be ignored by archives which have ArIgnoreArchetypeRef set

        EditHide = 0x0000020000000000,		// property should never be shown in a properties window.
        EditTextBox = 0x0000040000000000,		// property can be edited using a text dialog box.

        CrossLevelPassive = 0x0000100000000000,		// property can point across levels, and will be serialized properly, but assumes it's target exists in-game (non-editor)
        CrossLevelActive = 0x0000200000000000		// property can point across levels, and will be serialized properly, and will be updated when the target is streamed in/out
    };

    [Flags]
    public enum EClassFlags : ulong {
        None = 0x00000000,
        Abstract = 0x00000001, // Class is abstract and can't be instantiated directly.
        Compiled = 0x00000002,    // Script has been compiled successfully.
        Config = 0x00000004,  // Load object configuration at construction time.
        Transient = 0x00000008,   // This object type can't be saved; null it out at save time.
        Parsed = 0x00000010,  // Successfully parsed.
        Localized = 0x00000020,   // Class contains localized text.
        SafeReplace = 0x00000040, // Objects of this class can be safely replaced with default or NULL.
        Native = 0x00000080,   // Class is a native class - native interfaces will have CLASS_Native set, but not RF_Native
        NoExport = 0x00000100,    // Don't export to C++ header.
        Placeable = 0x00000200,   // Allow users to create in the editor.
        PerObjectConfig = 0x00000400, // Handle object configuration on a per-object basis, rather than per-class.
        NativeReplication = 0x00000800,   // Replication handled in C++.
        EditInlineNew = 0x00001000,   // Class can be constructed from editinline New button.
        CollapseCategories = 0x00002000,  // Display properties in the editor without using categories.
        Interface = 0x00004000, // Class is an interface
        HasInstancedProps = 0x00200000, // Indicates that this class contains object properties which are marked 'instanced' (or editinline export).  Set by the script compiler after all properties in the class have been parsed.  Used by the loading code as an optimization to attempt to instance newly added properties only for relevant classes
        NeedsDefProps = 0x00100000,   // Class needs its defaultproperties imported
        HasComponents = 0x00400000,   // Class has component properties.

        Hidden = 0x00800000,  // Don't show this class in the editor class browser or edit inline new menus.
        Deprecated = 0x01000000,  // Don't save objects of this class when serializing
        HideDropDown = 0x02000000,    // Class not shown in editor drop down for class selection

        Exported = 0x04000000,    // Class has been exported to a header file
        Intrinsic = 0x10000000, // Class has no unrealscript counter-part
        NativeOnly = 0x20000000, // Properties in this class can only be accessed from native code
        PerObjectLocalized = 0x40000000, // Handle object localization on a per-object basis, rather than per-class.
        HasCrossLevelRefs = 0x80000000, // This class has properties that are marked with CPF_CrossLevel

        // deprecated - these values now match the values of the EClassCastFlags enum
        CLASS_IsAUProperty = 0x00008000,
        CLASS_IsAUObjectProperty = 0x00010000,
        CLASS_IsAUBoolProperty = 0x00020000,
        CLASS_IsAUState = 0x00040000,
        CLASS_IsAUFunction = 0x00080000,
        CLASS_IsAUStructProperty = 0x00100000
    }

    public static string ConvertFlagsToString<T>(ulong flags) where T : struct, Enum {
        var flagNames = Enum.GetNames<T>();
        var flagValues = (ulong[])Enum.GetValuesAsUnderlyingType<T>();

        var result = "";
        var isFirst = true;

        for (var i = 0; i < flagNames.Length; i++) {
            if ((flags & flagValues[i]) != 0) {
                if (!isFirst) {
                    result += " | ";
                }
                result += flagNames[i];
                isFirst = false;
            }
        }

        return result;
    }
}
