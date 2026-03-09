using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.InteropServices.Marshalling;

namespace MediaDevices.Internal
{
    [GeneratedComInterface]
    [Guid("FD8878AC-D841-4D17-891C-E6829CDB6934")]
    internal partial interface IPortableDeviceResources
    {
        void GetSupportedResources(
            [MarshalAs(UnmanagedType.LPWStr)] string pszObjectID,
            [MarshalAs(UnmanagedType.Interface)] out IPortableDeviceKeyCollection ppKeys);

        void GetResourceAttributes(
            [MarshalAs(UnmanagedType.LPWStr)] string pszObjectID,
            in PropertyKey key,
            [MarshalAs(UnmanagedType.Interface)] out IPortableDeviceValues ppResourceAttributes);

        void GetStream(
            [MarshalAs(UnmanagedType.LPWStr)] string pszObjectID,
            in PropertyKey key,
            uint dwMode,
            ref uint pdwOptimalBufferSize,
            [MarshalAs(UnmanagedType.Interface)] out IStream ppStream);

        void Delete(
            [MarshalAs(UnmanagedType.LPWStr)] string pszObjectID,
            [MarshalAs(UnmanagedType.Interface)] IPortableDeviceKeyCollection pKeys);

        void Cancel();

        void CreateResource(
            [MarshalAs(UnmanagedType.Interface)] IPortableDeviceValues pResourceAttributes,
            [MarshalAs(UnmanagedType.Interface)] out IStream ppData,
            ref uint pdwOptimalWriteBufferSize,
            [MarshalAs(UnmanagedType.LPWStr)] ref string ppszCookie);
    }
}
