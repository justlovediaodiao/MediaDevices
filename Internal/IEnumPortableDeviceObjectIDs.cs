using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace MediaDevices.Internal
{
    [GeneratedComInterface]
    [Guid("10ECE955-CF41-4728-BFA0-41EEDF1BBF19")]
    internal partial interface IEnumPortableDeviceObjectIDs
    {
        void Next(
            uint cObjects,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPWStr)] string[] pObjIDs,
            ref uint pcFetched);

        void Skip(
            uint cObjects);

        void Reset();

        void Clone(
            [MarshalAs(UnmanagedType.Interface)] out IEnumPortableDeviceObjectIDs ppenum);

        void Cancel();
    }
}
