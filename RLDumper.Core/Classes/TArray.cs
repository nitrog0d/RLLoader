using System.Collections;

namespace RLDumper.Core.Classes;

public class TArrayBase<T> : BaseObject, IEnumerable<T> {
    public TArrayBase() { }
    public TArrayBase(nint address) : base(address) { }

    public virtual T this[int index] => throw new NotSupportedException();

    public int Count => RLDumper.ReadMemory<int>(Address + 8);

    public int Max => RLDumper.ReadMemory<int>(Address + 12);

    public IEnumerator<T> GetEnumerator() {
        var count = Count;
        for (var i = 0; i < count; i++) {
            yield return this[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

public class ObjectTArray<T> : TArrayBase<T> where T : BaseObject, new() {
    public ObjectTArray() { }
    public ObjectTArray(nint address) : base(address) { }

    public override T this[int index] {
        get {
            var address = RLDumper.ReadMemory<nint>(Address) + (index * 8);
            return address == nint.Zero ? null : new T() {
                Address = address
            };
        }
    }
}

public class UnmanagedTArray<T> : TArrayBase<T> where T : unmanaged {
    public UnmanagedTArray() { }
    public UnmanagedTArray(nint address) : base(address) { }

    public override T this[int index] {
        get {
            var address = RLDumper.ReadMemory<nint>(Address) + (index * 8);
            return RLDumper.ReadMemory<T>(address);
        }
    }
}

public class PointerTArray<T> : TArrayBase<T> where T : BaseObject, new() {
    public PointerTArray() { }
    public PointerTArray(nint address) : base(address) { }

    public override T this[int index] {
        get {
            var address = RLDumper.ReadMemory<nint>(RLDumper.ReadMemory<nint>(Address) + (index * 8));
            return address == nint.Zero ? null : new T() {
                Address = address
            };
        }
    }
}
