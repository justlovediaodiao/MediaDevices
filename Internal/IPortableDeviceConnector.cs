using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace MediaDevices.Internal
{
    [GeneratedComInterface]
    [Guid("A33B00DB-7F11-4A28-969C-F77EFD635E09")]
    internal partial interface IPortableDeviceConnector
    {
        void Connect([MarshalAs(UnmanagedType.Interface)] IConnectionRequestCallback pCallback);

        void Disconnect([MarshalAs(UnmanagedType.Interface)] IConnectionRequestCallback pCallback);

        void Cancel([MarshalAs(UnmanagedType.Interface)] IConnectionRequestCallback pCallback);

        void GetProperty(in PropertyKey pPropertyKey, out uint pPropertyType, out IntPtr ppData, out uint pcbData);

        void SetProperty(in PropertyKey pPropertyKey, uint PropertyType, in byte pData, uint cbData);

        void GetPnPID([MarshalAs(UnmanagedType.LPWStr)] out string ppwszPnPID);
    }
}
