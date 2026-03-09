using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace MediaDevices.Internal
{
    /// <summary>
    /// Helper class for activating COM objects in an AOT-compatible way.
    /// Replaces the pattern: (IInterface)new ComImportClass()
    /// </summary>
    internal static partial class ComActivationHelper
    {
        // CLSIDs for WPD COM objects
        internal static readonly Guid CLSID_PortableDevice = new Guid("728A21C5-3D9E-48D7-9810-864848F0F404");
        internal static readonly Guid CLSID_PortableDeviceManager = new Guid("0AF10CEC-2ECD-4B92-9581-34F6AE0637F3");
        internal static readonly Guid CLSID_PortableDeviceValues = new Guid("0C15D503-D017-47CE-9016-7B3F978721CC");
        internal static readonly Guid CLSID_PortableDeviceKeyCollection = new Guid("DE2D022D-2480-43BE-97F0-D1FA2CF98F4F");
        internal static readonly Guid CLSID_PortableDevicePropVariantCollection = new Guid("08A99E2F-6D6D-4B80-AF5A-BAF2BCBE4CB9");
        internal static readonly Guid CLSID_PortableDeviceService = new Guid("EF5DB4C2-9312-422C-9152-411CD9C4DD84");
        internal static readonly Guid CLSID_EnumPortableDeviceConnectors = new Guid("A1570149-E645-4F43-8B0D-409B061DB2FC");

        // IIDs for WPD interfaces
        internal static readonly Guid IID_IPortableDevice = new Guid("625E2DF8-6392-4CF0-9AD1-3CFA5F17775C");
        internal static readonly Guid IID_IPortableDeviceManager = new Guid("A1567595-4C2F-4574-A6FA-ECEF917B9A40");
        internal static readonly Guid IID_IPortableDeviceValues = new Guid("6848F6F2-3155-4F86-B6F5-263EEEAB3143");
        internal static readonly Guid IID_IPortableDeviceKeyCollection = new Guid("DADA2357-E0AD-492E-98DB-DD61C53BA353");
        internal static readonly Guid IID_IPortableDevicePropVariantCollection = new Guid("89B2E422-4F1B-4316-BCEF-A44AFEA83EB3");
        internal static readonly Guid IID_IPortableDeviceService = new Guid("D3BD3A44-D7B5-40A9-98B7-2FA4D01DEC08");
        internal static readonly Guid IID_IEnumPortableDeviceConnectors = new Guid("BFDEF549-9247-454F-BD82-06FE80853FAA");
        internal static readonly Guid IID_IPortableDeviceServiceManager = new Guid("a8abc4e9-a84a-47a9-80b3-c5d9b172a961");

        private static readonly ComWrappers _comWrappers = new StrategyBasedComWrappers();

        // CLSCTX_INPROC_SERVER = 0x1
        private const uint CLSCTX_INPROC_SERVER = 1;

        /// <summary>
        /// Activates a COM object using CoCreateInstance and wraps it for managed use.
        /// </summary>
        /// <typeparam name="T">The COM interface type to return</typeparam>
        /// <param name="clsid">The CLSID of the COM class to activate</param>
        /// <param name="iid">The IID of the interface to query</param>
        /// <returns>The activated COM object wrapped as the specified interface</returns>
        public static T Activate<T>(Guid clsid, Guid iid) where T : class
        {
            int hr = CoCreateInstance(in clsid, IntPtr.Zero, CLSCTX_INPROC_SERVER, in iid, out IntPtr ppv);
            if (hr < 0)
            {
                Marshal.ThrowExceptionForHR(hr);
            }

            try
            {
                return (T)_comWrappers.GetOrCreateObjectForComInstance(ppv, CreateObjectFlags.None);
            }
            finally
            {
                // The ComWrappers creates its own reference, so we can release the original
                Marshal.Release(ppv);
            }
        }

        /// <summary>
        /// Queries an existing COM object for a different interface.
        /// Used instead of direct C# casts which do not perform QI with StrategyBasedComWrappers.
        /// </summary>
        public static T QueryInterface<T>(object comObject, Guid iid) where T : class
        {
            IntPtr pUnk = _comWrappers.GetOrCreateComInterfaceForObject(comObject, CreateComInterfaceFlags.None);
            try
            {
                int hr = Marshal.QueryInterface(pUnk, in iid, out IntPtr ppv);
                if (hr < 0)
                {
                    Marshal.ThrowExceptionForHR(hr);
                }
                try
                {
                    return (T)_comWrappers.GetOrCreateObjectForComInstance(ppv, CreateObjectFlags.None);
                }
                finally
                {
                    Marshal.Release(ppv);
                }
            }
            finally
            {
                Marshal.Release(pUnk);
            }
        }

        /// <summary>
        /// Specific activation helpers for common WPD objects
        /// </summary>
        public static IPortableDevice CreatePortableDevice() =>
            Activate<IPortableDevice>(CLSID_PortableDevice, IID_IPortableDevice);

        public static IPortableDeviceManager CreatePortableDeviceManager() =>
            Activate<IPortableDeviceManager>(CLSID_PortableDeviceManager, IID_IPortableDeviceManager);

        public static IPortableDeviceValues CreatePortableDeviceValues() =>
            Activate<IPortableDeviceValues>(CLSID_PortableDeviceValues, IID_IPortableDeviceValues);

        public static IPortableDeviceKeyCollection CreatePortableDeviceKeyCollection() =>
            Activate<IPortableDeviceKeyCollection>(CLSID_PortableDeviceKeyCollection, IID_IPortableDeviceKeyCollection);

        public static IPortableDevicePropVariantCollection CreatePortableDevicePropVariantCollection() =>
            Activate<IPortableDevicePropVariantCollection>(CLSID_PortableDevicePropVariantCollection, IID_IPortableDevicePropVariantCollection);

        public static IPortableDeviceService CreatePortableDeviceService() =>
            Activate<IPortableDeviceService>(CLSID_PortableDeviceService, IID_IPortableDeviceService);

        public static IEnumPortableDeviceConnectors CreateEnumPortableDeviceConnectors() =>
            Activate<IEnumPortableDeviceConnectors>(CLSID_EnumPortableDeviceConnectors, IID_IEnumPortableDeviceConnectors);

        [LibraryImport("ole32.dll", SetLastError = true)]
        private static partial int CoCreateInstance(
            in Guid rclsid,
            IntPtr pUnkOuter,
            uint dwClsContext,
            in Guid riid,
            out IntPtr ppv);
    }
}
