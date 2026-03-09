using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace MediaDevices.Internal
{
    /// <summary>
    /// Callback interface for device events. Implemented by managed code (EventCallback class).
    /// </summary>
    [GeneratedComInterface]
    [Guid("A8792A31-F385-493C-A893-40F64EB45F6E")]
    internal partial interface IPortableDeviceEventCallback
    {
        void OnEvent(
            [MarshalAs(UnmanagedType.Interface)] IPortableDeviceValues pEventParameters);
    }
}
