using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace MediaDevices.Internal
{
    [GeneratedComInterface]
    [Guid("24DBD89D-413E-43E0-BD5B-197F3C56C886")]
    internal partial interface IPortableDeviceServiceCapabilities
    {
        void GetSupportedMethods([MarshalAs(UnmanagedType.Interface)] out IPortableDevicePropVariantCollection ppMethods);

        void GetSupportedMethodsByFormat(in Guid Format, [MarshalAs(UnmanagedType.Interface)] out IPortableDevicePropVariantCollection ppMethods);

        void GetMethodAttributes(in Guid Method, [MarshalAs(UnmanagedType.Interface)] out IPortableDeviceValues ppAttributes);

        void GetMethodParameterAttributes(in Guid Method, in PropertyKey Parameter, [MarshalAs(UnmanagedType.Interface)] out IPortableDeviceValues ppAttributes);

        void GetSupportedFormats([MarshalAs(UnmanagedType.Interface)] out IPortableDevicePropVariantCollection ppFormats);

        void GetFormatAttributes(in Guid Format, [MarshalAs(UnmanagedType.Interface)] out IPortableDeviceValues ppAttributes);

        void GetSupportedFormatProperties(in Guid Format, [MarshalAs(UnmanagedType.Interface)] out IPortableDeviceKeyCollection ppKeys);

        void GetFormatPropertyAttributes(in Guid Format, in PropertyKey Property, [MarshalAs(UnmanagedType.Interface)] out IPortableDeviceValues ppAttributes);

        void GetSupportedEvents([MarshalAs(UnmanagedType.Interface)] out IPortableDevicePropVariantCollection ppEvents);

        void GetEventAttributes(in Guid Event, [MarshalAs(UnmanagedType.Interface)] out IPortableDeviceValues ppAttributes);

        void GetEventParameterAttributes(in Guid Event, in PropertyKey Parameter, [MarshalAs(UnmanagedType.Interface)] out IPortableDeviceValues ppAttributes);

        void GetInheritedServices(uint dwInheritanceType, [MarshalAs(UnmanagedType.Interface)] out IPortableDevicePropVariantCollection ppServices);

        void GetFormatRenderingProfiles(in Guid Format, [MarshalAs(UnmanagedType.Interface)] out IPortableDeviceValuesCollection ppRenderingProfiles);

        void GetSupportedCommands([MarshalAs(UnmanagedType.Interface)] out IPortableDeviceKeyCollection ppCommands);

        void GetCommandOptions(in PropertyKey Command, [MarshalAs(UnmanagedType.Interface)] out IPortableDeviceValues ppOptions);

        void Cancel();
    }
}
