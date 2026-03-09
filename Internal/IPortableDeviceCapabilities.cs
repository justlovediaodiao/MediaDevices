using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace MediaDevices.Internal
{
    [GeneratedComInterface]
    [Guid("2C8C6DBF-E3DC-4061-BECC-8542E810D126")]
    internal partial interface IPortableDeviceCapabilities
    {
        void GetSupportedCommands(
            [MarshalAs(UnmanagedType.Interface)] out IPortableDeviceKeyCollection ppCommands);

        void GetCommandOptions(
            in PropertyKey Command,
            [MarshalAs(UnmanagedType.Interface)] out IPortableDeviceValues ppOptions);

        void GetFunctionalCategories(
            [MarshalAs(UnmanagedType.Interface)] out IPortableDevicePropVariantCollection ppCategories);

        void GetFunctionalObjects(
            in Guid Category,
            [MarshalAs(UnmanagedType.Interface)] out IPortableDevicePropVariantCollection ppObjectIDs);

        void GetSupportedContentTypes(
            in Guid Category,
            [MarshalAs(UnmanagedType.Interface)] out IPortableDevicePropVariantCollection ppContentTypes);

        void GetSupportedFormats(
            in Guid ContentType,
            [MarshalAs(UnmanagedType.Interface)] out IPortableDevicePropVariantCollection ppFormats);

        void GetSupportedFormatProperties(
            in Guid Format,
            [MarshalAs(UnmanagedType.Interface)] out IPortableDeviceKeyCollection ppKeys);

        void GetFixedPropertyAttributes(
            in Guid Format,
            in PropertyKey key,
            [MarshalAs(UnmanagedType.Interface)] out IPortableDeviceValues ppAttributes);

        void Cancel();

        void GetSupportedEvents(
            [MarshalAs(UnmanagedType.Interface)] out IPortableDevicePropVariantCollection ppEvents);

        void GetEventOptions(
            in Guid Event,
            [MarshalAs(UnmanagedType.Interface)] out IPortableDeviceValues ppOptions);
    }
}
