using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace MediaDevices.Internal
{
    [GeneratedComInterface]
    [Guid("625E2DF8-6392-4CF0-9AD1-3CFA5F17775C")]
    internal partial interface IPortableDevice
    {
        void Open(
            [MarshalAs(UnmanagedType.LPWStr)] string pszPnPDeviceID,
            [MarshalAs(UnmanagedType.Interface)] IPortableDeviceValues pClientInfo);

        void SendCommand(
            uint dwFlags,
            [MarshalAs(UnmanagedType.Interface)] IPortableDeviceValues pParameters,
            [MarshalAs(UnmanagedType.Interface)] out IPortableDeviceValues ppResults);

        void Content(
            [MarshalAs(UnmanagedType.Interface)] out IPortableDeviceContent ppContent);

        void Capabilities(
            [MarshalAs(UnmanagedType.Interface)] out IPortableDeviceCapabilities ppCapabilities);

        void Cancel();

        void Close();

        void Advise(
            uint dwFlags,
            [MarshalAs(UnmanagedType.Interface)] IPortableDeviceEventCallback pCallback,
            [MarshalAs(UnmanagedType.Interface)] IPortableDeviceValues pParameters,
            [MarshalAs(UnmanagedType.LPWStr)] out string ppszCookie);

        void Unadvise(
            [MarshalAs(UnmanagedType.LPWStr)] string pszCookie);

        void GetPnPDeviceID(
            [MarshalAs(UnmanagedType.LPWStr)] out string ppszPnPDeviceID);
    }
}
