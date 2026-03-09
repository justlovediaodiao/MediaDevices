using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace MediaDevices.Internal
{
    [GeneratedComInterface]
    [Guid("6E3F2D79-4E07-48C4-8208-D8C2E5AF4A99")]
    internal partial interface IPortableDeviceValuesCollection
    {
        void GetCount(
            ref uint pcElems);

        void GetAt(
            uint dwIndex,
            [MarshalAs(UnmanagedType.Interface)] out IPortableDeviceValues ppValues);

        void Add(
            [MarshalAs(UnmanagedType.Interface)] IPortableDeviceValues pValues);

        void Clear();

        void RemoveAt(
            uint dwIndex);
    }
}
