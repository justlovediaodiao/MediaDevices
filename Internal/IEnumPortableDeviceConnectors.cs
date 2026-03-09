using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace MediaDevices.Internal
{
    [GeneratedComInterface]
    [Guid("BFDEF549-9247-454F-BD82-06FE80853FAA")]
    internal partial interface IEnumPortableDeviceConnectors
    {
        void Next(
            uint cRequested,
            [MarshalAs(UnmanagedType.Interface)] out IPortableDeviceConnector pConnectors,
            ref uint pcFetched);

        void Skip(
            uint cConnectors);

        void Reset();

        void Clone(
            [MarshalAs(UnmanagedType.Interface)] out IEnumPortableDeviceConnectors ppEnum);
    }
}
