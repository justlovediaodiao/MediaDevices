using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace MediaDevices.Internal
{
    [GeneratedComInterface]
    [Guid("A1567595-4C2F-4574-A6FA-ECEF917B9A40")]
    internal partial interface IPortableDeviceManager
    {
        void GetDevices(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPWStr)] string[] pPnPDeviceIDs,
            ref uint pcPnPDeviceIDs);

        void RefreshDeviceList();

        void GetDeviceFriendlyName(
            [MarshalAs(UnmanagedType.LPWStr)] string pszPnPDeviceID,
            IntPtr pDeviceFriendlyName,
            ref uint pcchDeviceFriendlyName);

        void GetDeviceDescription(
            [MarshalAs(UnmanagedType.LPWStr)] string pszPnPDeviceID,
            IntPtr pDeviceDescription,
            ref uint pcchDeviceDescription);

        void GetDeviceManufacturer(
            [MarshalAs(UnmanagedType.LPWStr)] string pszPnPDeviceID,
            IntPtr pDeviceManufacturer,
            ref uint pcchDeviceManufacturer);

        void GetDeviceProperty(
            [MarshalAs(UnmanagedType.LPWStr)] string pszPnPDeviceID,
            [MarshalAs(UnmanagedType.LPWStr)] string pszDevicePropertyName,
            IntPtr pData,
            ref uint pcbData,
            ref uint pdwType);

        void GetPrivateDevices(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPWStr)] string[] pPnPDeviceIDs,
            ref uint pcPnPDeviceIDs);
    }
}
