using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace MediaDevices.Internal
{
    [GeneratedComInterface]
    [Guid("89B2E422-4F1B-4316-BCEF-A44AFEA83EB3")]
    internal partial interface IPortableDevicePropVariantCollection
    {
        void GetCount(
            ref uint pcElems);

        void GetAt(
            uint dwIndex,
            out PropVariant pValue);

        void Add(
            in PropVariant pValue);

        void GetType(
            out ushort pvt);

        void ChangeType(
            ushort vt);

        void Clear();

        void RemoveAt(
            uint dwIndex);
    }
}
