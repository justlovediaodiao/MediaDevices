using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace MediaDevices.Internal
{
    [GeneratedComInterface]
    [Guid("7F6D695C-03DF-4439-A809-59266BEEE3A6")]
    internal partial interface IPortableDeviceProperties
    {
        void GetSupportedProperties(
            [MarshalAs(UnmanagedType.LPWStr)] string pszObjectID,
            [MarshalAs(UnmanagedType.Interface)] out IPortableDeviceKeyCollection ppKeys);

        void GetPropertyAttributes(
            [MarshalAs(UnmanagedType.LPWStr)] string pszObjectID,
            in PropertyKey key,
            [MarshalAs(UnmanagedType.Interface)] out IPortableDeviceValues ppAttributes);

        void GetValues(
            [MarshalAs(UnmanagedType.LPWStr)] string pszObjectID,
            [MarshalAs(UnmanagedType.Interface)] IPortableDeviceKeyCollection pKeys,
            [MarshalAs(UnmanagedType.Interface)] out IPortableDeviceValues ppValues);

        void SetValues(
            [MarshalAs(UnmanagedType.LPWStr)] string pszObjectID,
            [MarshalAs(UnmanagedType.Interface)] IPortableDeviceValues pValues,
            [MarshalAs(UnmanagedType.Interface)] out IPortableDeviceValues ppResults);

        void Delete(
            [MarshalAs(UnmanagedType.LPWStr)] string pszObjectID,
            [MarshalAs(UnmanagedType.Interface)] IPortableDeviceKeyCollection pKeys);

        void Cancel();
    }
}
