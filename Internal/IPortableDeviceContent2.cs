using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.InteropServices.Marshalling;

namespace MediaDevices.Internal
{
    [GeneratedComInterface]
    [Guid("9B4ADD96-F6BF-4034-8708-ECA72BF10554")]
    internal partial interface IPortableDeviceContent2
    {
        // Methods from IPortableDeviceContent (must be listed first to maintain vtable order)
        void EnumObjects(
            uint dwFlags,
            [MarshalAs(UnmanagedType.LPWStr)] string pszParentObjectID,
            [MarshalAs(UnmanagedType.Interface)] IPortableDeviceValues pFilter,
            [MarshalAs(UnmanagedType.Interface)] out IEnumPortableDeviceObjectIDs ppenum);

        void Properties(
            [MarshalAs(UnmanagedType.Interface)] out IPortableDeviceProperties ppProperties);

        void Transfer(
            [MarshalAs(UnmanagedType.Interface)] out IPortableDeviceResources ppResources);

        void CreateObjectWithPropertiesOnly(
            [MarshalAs(UnmanagedType.Interface)] IPortableDeviceValues pValues,
            [MarshalAs(UnmanagedType.LPWStr)] ref string ppszObjectID);

        void CreateObjectWithPropertiesAndData(
            [MarshalAs(UnmanagedType.Interface)] IPortableDeviceValues pValues,
            [MarshalAs(UnmanagedType.Interface)] out IStream ppData,
            ref uint pdwOptimalWriteBufferSize,
            [MarshalAs(UnmanagedType.LPWStr)] ref string ppszCookie);

        void Delete(
            uint dwOptions,
            [MarshalAs(UnmanagedType.Interface)] IPortableDevicePropVariantCollection pObjectIDs,
            [MarshalAs(UnmanagedType.Interface)] ref IPortableDevicePropVariantCollection ppResults);

        void GetObjectIDsFromPersistentUniqueIDs(
            [MarshalAs(UnmanagedType.Interface)] IPortableDevicePropVariantCollection pPersistentUniqueIDs,
            [MarshalAs(UnmanagedType.Interface)] out IPortableDevicePropVariantCollection ppObjectIDs);

        void Cancel();

        void Move(
            [MarshalAs(UnmanagedType.Interface)] IPortableDevicePropVariantCollection pObjectIDs,
            [MarshalAs(UnmanagedType.LPWStr)] string pszDestinationFolderObjectID,
            [MarshalAs(UnmanagedType.Interface)] ref IPortableDevicePropVariantCollection ppResults);

        void Copy(
            [MarshalAs(UnmanagedType.Interface)] IPortableDevicePropVariantCollection pObjectIDs,
            [MarshalAs(UnmanagedType.LPWStr)] string pszDestinationFolderObjectID,
            [MarshalAs(UnmanagedType.Interface)] ref IPortableDevicePropVariantCollection ppResults);

        // IPortableDeviceContent2 method
        void UpdateObjectWithPropertiesAndData(
            [MarshalAs(UnmanagedType.LPWStr)] string pszObjectID,
            [MarshalAs(UnmanagedType.Interface)] IPortableDeviceValues pProperties,
            [MarshalAs(UnmanagedType.Interface)] out IStream ppData,
            ref uint pdwOptimalWriteBufferSize);
    }
}
