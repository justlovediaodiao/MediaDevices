using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace MediaDevices.Internal
{
    [GeneratedComInterface]
    [Guid("a8abc4e9-a84a-47a9-80b3-c5d9b172a961")]
    internal partial interface IPortableDeviceServiceManager
    {
        void GetDeviceServices(
            [MarshalAs(UnmanagedType.LPWStr)] string pszPnPDeviceID,
            in Guid guidServiceCategory,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPWStr)] string[] pServices,
            ref uint pcServices);

        void GetDeviceForService(
            [MarshalAs(UnmanagedType.LPWStr)] string pszPnPServiceID,
            [MarshalAs(UnmanagedType.LPWStr)] out string ppszPnPDeviceID);
    }
}
