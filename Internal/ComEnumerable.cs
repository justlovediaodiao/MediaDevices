using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;

namespace MediaDevices.Internal
{
    internal static class ComEnumerable
    {
        public static IEnumerable<KeyValuePair<string, string>> ToKeyValuePair(this IPortableDeviceValues values)
        {
            uint num = 0;
            values?.GetCount(ref num);
            for (uint i = 0; i < num; i++)
            {
                PropertyKey key = new PropertyKey();
                using (PropVariantFacade val = new PropVariantFacade())
                {
                    values.GetAt(i, ref key, ref val.Value);


                    string fieldName = string.Empty;
                    FieldInfo propField = ComTrace.FindPropertyKeyField(key);
                    if (propField != null)
                    {
                        fieldName = propField.Name;
                    }
                    else
                    {
                        FieldInfo guidField = ComTrace.FindGuidField(key.fmtid);
                        if (guidField != null)
                        {
                            fieldName = $"{guidField.Name}, {key.pid}";
                        }
                        else
                        {
                            fieldName = $"{key.fmtid}, {key.pid}";
                        }
                    }
                    string fieldValue = string.Empty;
                    switch (val.VariantType)
                    {
                        case PropVariantType.VT_CLSID:
                            fieldValue = ComTrace.FindGuidField(val.ToGuid())?.Name ?? val.ToString();
                            break;
                        default:
                            fieldValue = val.ToDebugString();
                            break;
                    }

                    yield return new KeyValuePair<string, string>(fieldName, fieldValue);
                }
            }

        }

        [UnconditionalSuppressMessage("Trimming", "IL2075", Justification = "Enum fields are preserved by the caller")]
        public static Guid Guid(this Enum e)
        {
            FieldInfo fi = e.GetType().GetField(e.ToString());

            // changed for .net framework 4.0
            // EnumGuidAttribute attribute = fi.GetCustomAttribute<EnumGuidAttribute>();
            EnumGuidAttribute attribute = Attribute.GetCustomAttribute(fi, typeof(EnumGuidAttribute)) as EnumGuidAttribute;
            return attribute.Guid;
        }

        public static IEnumerable<PropertyKey> ToEnum(this IPortableDeviceKeyCollection col) 
        {
            uint count = 0;
            col.GetCount(ref count);
            for (uint i = 0; i < count; i++)
            {
                PropertyKey key = new PropertyKey();
                col.GetAt(i, out key);
                yield return key;
            }
        }

        public static IEnumerable<TEnum> ToEnum<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields)] TEnum>(this IPortableDeviceKeyCollection col) where TEnum : struct, Enum
        {
            uint count = 0;
            col.GetCount(ref count);
            for (uint i = 0; i < count; i++)
            {
                PropertyKey key = new PropertyKey();
                col.GetAt(i, out key);
                yield return GetEnumFromAttrKey<TEnum>(key);
            }
        }

        public static IEnumerable<TEnum> ToEnum<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields)] TEnum>(this IPortableDevicePropVariantCollection col) where TEnum : struct, Enum
        {
            uint count = 0;
            col.GetCount(ref count);
            for (uint i = 0; i < count; i++)
            {
                using (PropVariantFacade val = new PropVariantFacade())
                {
                    col.GetAt(i, out val.Value);
                    yield return GetEnumFromAttrGuid<TEnum>(val.ToGuid());
                }
            }
        }

        public static T GetEnum<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields)] T>(this Guid guid) where T : struct, Enum
        {
            T en = Enum.GetValues<T>().Where(e =>
            {
                // changed for .net framework 4.0
                // EnumGuidAttribute ea = e.GetType().GetField(e.ToString()).GetCustomAttribute<EnumGuidAttribute>();
                EnumGuidAttribute ea = Attribute.GetCustomAttribute(typeof(T).GetField(e.ToString()), typeof(EnumGuidAttribute)) as EnumGuidAttribute;
                return ea.Guid == guid;
            }).FirstOrDefault();
            return en;
        }


        public static T GetEnumFromAttrKey<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields)] T>(this PropertyKey key) where T : struct, Enum
        {
            T en = Enum.GetValues<T>().Where(e =>
            {
                // changed for .net framework 4.0
                // KeyAttribute attr = e.GetType().GetField(e.ToString()).GetCustomAttribute<KeyAttribute>();
                KeyAttribute attr = Attribute.GetCustomAttribute(typeof(T).GetField(e.ToString()), typeof(KeyAttribute)) as KeyAttribute;
                return attr.PropertyKey == key;
            }).FirstOrDefault();
            if (en.Equals(default(T)))
            {
                Trace.TraceWarning($"Unknown {typeof(T).Name} Key {key.fmtid}  {key.pid}");
            }
            return en;
        }


        public static T GetEnumFromAttrGuid<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields)] T>(this Guid guid) where T : struct, Enum
        {
            T en = Enum.GetValues<T>().Where(e =>
            {
                // changed for .net framework 4.0
                // return e.GetType().GetField(e.ToString()).GetCustomAttribute<EnumGuidAttribute>().Guid == guid;
                return (Attribute.GetCustomAttribute(typeof(T).GetField(e.ToString()), typeof(EnumGuidAttribute)) as EnumGuidAttribute).Guid == guid;
            }).FirstOrDefault();
            if (en.Equals(default(T)))
            {
                Trace.TraceWarning($"Unknown {typeof(T).Name} Guid {guid}");
            }
            return en;
        }

        public static IEnumerable<Guid> ToGuid(this IPortableDevicePropVariantCollection col) 
        {
            uint count = 0;
            col.GetCount(ref count);
            for (uint i = 0; i < count; i++)
            {
                using (PropVariantFacade val = new PropVariantFacade())
                {
                    col.GetAt(i, out val.Value);
                    yield return val.ToGuid();
                }
            }
        }

        public static IEnumerable<string> ToStrings(this IPortableDevicePropVariantCollection col)
        {
            uint count = 0;
            col.GetCount(ref count);
            for (uint i = 0; i < count; i++)
            {
                using (PropVariantFacade val = new PropVariantFacade())
                {
                    col.GetAt(i, out val.Value);
                    yield return val.ToString();
                }
            }
        }
    }
}
