using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace MediaDevices.Internal
{
    [GeneratedComInterface]
    [Guid("6848F6F2-3155-4F86-B6F5-263EEEAB3143")]
    internal partial interface IPortableDeviceValues
    {
        void GetCount(
             ref uint pcelt);

        void GetAt(
            uint index,
            ref PropertyKey pKey,
            ref PropVariant pValue);

        void SetValue(
            in PropertyKey key,
            in PropVariant pValue);

        void GetValue(
            in PropertyKey key,
            out PropVariant pValue);

        void SetStringValue(
            in PropertyKey key,
            [MarshalAs(UnmanagedType.LPWStr)] string Value);

        void GetStringValue(
            in PropertyKey key,
            [MarshalAs(UnmanagedType.LPWStr)] out string pValue);

        void SetUnsignedIntegerValue(
            in PropertyKey key,
            uint Value);

        void GetUnsignedIntegerValue(
            in PropertyKey key,
            out uint pValue);

        void SetSignedIntegerValue(
            in PropertyKey key,
            int Value);

        void GetSignedIntegerValue(
            in PropertyKey key,
            out int pValue);

        void SetUnsignedLargeIntegerValue(
            in PropertyKey key,
            ulong Value);

        void GetUnsignedLargeIntegerValue(
            in PropertyKey key,
            out ulong pValue);

        void SetSignedLargeIntegerValue(
            in PropertyKey key,
            long Value);

        void GetSignedLargeIntegerValue(
            in PropertyKey key,
            out long pValue);

        void SetFloatValue(
            in PropertyKey key,
            float Value);

        void GetFloatValue(
            in PropertyKey key,
            out float pValue);

        void SetErrorValue(
            in PropertyKey key,
            int Value);

        void GetErrorValue(
            in PropertyKey key,
            out int pValue);

        void SetKeyValue(
            in PropertyKey key,
            in PropertyKey Value);

        void GetKeyValue(
            in PropertyKey key,
            out PropertyKey pValue);

        void SetBoolValue(
            in PropertyKey key,
            int Value);

        void GetBoolValue(
            in PropertyKey key,
            out int pValue);

        void SetIUnknownValue(
            in PropertyKey key,
            IntPtr pValue);

        void GetIUnknownValue(
            in PropertyKey key,
            out IntPtr ppValue);

        void SetGuidValue(
            in PropertyKey key,
            in Guid Value);

        void GetGuidValue(
            in PropertyKey key,
            out Guid pValue);

        void SetBufferValue(
            in PropertyKey key,
            in byte pValue,
            uint cbValue);

        void GetBufferValue(
            in PropertyKey key,
            out IntPtr ppValue,
            out uint pcbValue);

        void SetIPortableDeviceValuesValue(
            in PropertyKey key,
            [MarshalAs(UnmanagedType.Interface)] IPortableDeviceValues pValue);

        void GetIPortableDeviceValuesValue(
            in PropertyKey key,
            [MarshalAs(UnmanagedType.Interface)] out IPortableDeviceValues ppValue);

        void SetIPortableDevicePropVariantCollectionValue(
            in PropertyKey key,
            [MarshalAs(UnmanagedType.Interface)] IPortableDevicePropVariantCollection pValue);

        void GetIPortableDevicePropVariantCollectionValue(
            in PropertyKey key,
            [MarshalAs(UnmanagedType.Interface)] out IPortableDevicePropVariantCollection ppValue);

        void SetIPortableDeviceKeyCollectionValue(
            in PropertyKey key,
            [MarshalAs(UnmanagedType.Interface)] IPortableDeviceKeyCollection pValue);

        void GetIPortableDeviceKeyCollectionValue(
            in PropertyKey key,
            [MarshalAs(UnmanagedType.Interface)] out IPortableDeviceKeyCollection ppValue);

        void SetIPortableDeviceValuesCollectionValue(
            in PropertyKey key,
            [MarshalAs(UnmanagedType.Interface)] IPortableDeviceValuesCollection pValue);

        void GetIPortableDeviceValuesCollectionValue(
            in PropertyKey key,
            [MarshalAs(UnmanagedType.Interface)] out IPortableDeviceValuesCollection ppValue);

        void RemoveValue(
            in PropertyKey key);

        void CopyValuesFromPropertyStore(
            [MarshalAs(UnmanagedType.Interface)] IPropertyStore pStore);

        void CopyValuesToPropertyStore(
            [MarshalAs(UnmanagedType.Interface)] IPropertyStore pStore);

        void Clear();
    }
}
