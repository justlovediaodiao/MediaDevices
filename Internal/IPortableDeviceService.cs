using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace MediaDevices.Internal
{
    [GeneratedComInterface]
    [Guid("D3BD3A44-D7B5-40A9-98B7-2FA4D01DEC08")]
    internal partial interface IPortableDeviceService
    {
        void Open(
            [MarshalAs(UnmanagedType.LPWStr)] string pszPnPServiceID,
            [MarshalAs(UnmanagedType.Interface)] IPortableDeviceValues pClientInfo);

        void Capabilities(
            [MarshalAs(UnmanagedType.Interface)] out IPortableDeviceServiceCapabilities ppCapabilities);

        void Content(
            [MarshalAs(UnmanagedType.Interface)] out IPortableDeviceContent2 ppContent);

        void Methods(
            [MarshalAs(UnmanagedType.Interface)] out IPortableDeviceServiceMethods ppMethods);

        void Cancel();

        void Close();

        void GetServiceObjectID(
            [MarshalAs(UnmanagedType.LPWStr)] out string ppszServiceObjectID);

        void GetPnPServiceID(
            [MarshalAs(UnmanagedType.LPWStr)] out string ppszPnPServiceID);

        void Advise(
            uint dwFlags,
            [MarshalAs(UnmanagedType.Interface)] IPortableDeviceEventCallback pCallback,
            [MarshalAs(UnmanagedType.Interface)] IPortableDeviceValues pParameters,
            [MarshalAs(UnmanagedType.LPWStr)] out string ppszCookie);

        void Unadvise([MarshalAs(UnmanagedType.LPWStr)] string pszCookie);

        void SendCommand(
            uint dwFlags,
            [MarshalAs(UnmanagedType.Interface)] ref IPortableDeviceValues pParameters,
            [MarshalAs(UnmanagedType.Interface)] out IPortableDeviceValues ppResults);
    }
}
