namespace RLDumper.Core.Classes;

public class BaseObject {
    public BaseObject() { }
    public BaseObject(nint address) => Address = address;

    public nint Address { get; set; }

    public T As<T>() where T : BaseObject, new() {
        return new T() {
            Address = Address
        };
    }
}
