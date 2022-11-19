using System.Runtime.InteropServices;

#region User defined

[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IComInterface1
{
    void Method();
}

[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IComInterface2
{
    void Method1();
    void Method2();
}

[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IComInterface3
{
    void Method();
}

// Minimal implementation for all IUnknown based scenarios.
internal sealed unsafe class MyComObject : MyComObjectBase
{
    internal MyComObject(void* thisPtr)
        : base(thisPtr)
    {
    }
}
#endregion User defined
