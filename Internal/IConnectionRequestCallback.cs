using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace MediaDevices.Internal
{
    [GeneratedComInterface]
    [Guid("272C9AE0-7161-4AE0-91BD-9F448EE9C427")]
    internal partial interface IConnectionRequestCallback
    {
        void OnComplete([MarshalAs(UnmanagedType.Error)] int hrStatus);
    }
}
