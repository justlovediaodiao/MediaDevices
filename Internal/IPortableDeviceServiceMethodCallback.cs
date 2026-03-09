using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace MediaDevices.Internal
{
    /// <summary>
    /// Callback interface for service method completion. Implemented by managed code.
    /// </summary>
    [GeneratedComInterface]
    [Guid("C424233C-AFCE-4828-A756-7ED7A2350083")]
    internal partial interface IPortableDeviceServiceMethodCallback
    {
        void OnComplete(
            [MarshalAs(UnmanagedType.Error)] int hrStatus,
            [MarshalAs(UnmanagedType.Interface)] IPortableDeviceValues pResults);
    }
}
