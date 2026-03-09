using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace MediaDevices.Internal
{
    [GeneratedComInterface]
    [Guid("E20333C9-FD34-412D-A381-CC6F2D820DF7")]
    internal partial interface IPortableDeviceServiceMethods
    {
        void Invoke(in Guid Method, [MarshalAs(UnmanagedType.Interface)] ref IPortableDeviceValues pParameters, [MarshalAs(UnmanagedType.Interface)] ref IPortableDeviceValues ppResults);

        void InvokeAsync(in Guid Method, [MarshalAs(UnmanagedType.Interface)] ref IPortableDeviceValues pParameters, [MarshalAs(UnmanagedType.Interface)] IPortableDeviceServiceMethodCallback pCallback);

        void Cancel([MarshalAs(UnmanagedType.Interface)] ref IPortableDeviceServiceMethodCallback pCallback);
    }
}
