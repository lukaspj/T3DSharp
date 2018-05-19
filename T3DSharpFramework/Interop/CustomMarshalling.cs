using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using T3DSharpFramework.Engine;

namespace T3DSharpFramework.Interop
{
    /// <summary>
    /// A static class to help ease marshalling strings between managed and 
    /// unmanaged code.
    /// 
    /// Some references for marshaling strings:
    /// http://stackoverflow.com/questions/1498931/marshalling-array-of-strings-to-char-in-c-sharp
    /// </summary>
    public static class StringMarshal
    {
        public static string[] IntPtrToStringArray(IntPtr ptr, int count) {
            //convert the received pointer into a pointer array
            IntPtr[] stringPointers = new IntPtr[count];
            Marshal.Copy(ptr, stringPointers, 0, count);
            //convert the pointer array into a string array
            string[] strings = new string[count];
            for (int i = 0; i < count; i++) {
                if (stringPointers[i] == IntPtr.Zero) {
                    strings[i] = null;
                }
                else {
                    strings[i] = Marshal.PtrToStringAnsi(stringPointers[i]);
                }
            }

            return strings;
        }


        /// <summary>
        /// Marshals an array of strings str into an array of heap allocated strings.
        /// </summary>
        /// <param name="str">An array of strings.</param>
        /// <returns>An array of int pointers to marshal to the native api.</returns>
        public static IntPtr[] StringArrayToIntPtrArray(string[] str) {
            int length = str.Length;
            IntPtr[] arr = new IntPtr[length];
            for (int i = 0; i < length; i++) {
                arr[i] = Marshal.StringToHGlobalUni(str[i]);
            }

            return arr;
        }

        /// <summary>
        /// Frees an array of heap allocated data stored in an IntPtr array.
        /// </summary>
        /// <param name="arr">The array of int pointers.</param>
        public static void FreeIntPtrArray(IntPtr[] arr) {
            int length = arr.Length;
            for (int i = 0; i < length; i++) {
                Marshal.FreeHGlobal(arr[i]);
            }
        }
    }

    public static class GenericMarshal
    {
        public static bool StringToBool(string str) {
            switch (str) {
                case "1":
                    return true;
                case "0":
                    return false;
                case "":
                    return false;
                default:
                    return Boolean.Parse(str);
            }
        }
        
        public static string ToString(string s) {
            return s;
        }
        
        public static string ToString(bool b) {
            return b ? "1" : "0";
        }
        
        public static string ToString(int i) {
            return i.ToString();
        }
        
        public static string ToString(long l) {
            return l.ToString();
        }
        
        public static string ToString(float f) {
            return f.ToString(CultureInfo.InvariantCulture);
        }
        
        public static string ToString(double d) {
            return d.ToString(CultureInfo.InvariantCulture);
        }
        
        public static string ToString(ISimObject sim) {
            return sim.Name;
        }
        
        public static string ToString(IEngineStruct engineStruct) {
            return engineStruct.ToString();
        }

        public static T StringTo<T>(string s) {
            bool found = false;
            object ret = null;
            if (typeof(T) == typeof(string)) {
                found = true;
                ret = s;
            } else if (typeof(T) == typeof(char)) {
                found = true;
                ret = char.Parse(s);
            } else if (typeof(T) == typeof(int)) {
                found = true;
                ret = int.Parse(s);
            } else if (typeof(T) == typeof(long)) {
                found = true;
                ret = long.Parse(s);
            } else if (typeof(T) == typeof(float)) {
                found = true;
                ret = float.Parse(s);
            } else if (typeof(T) == typeof(double)) {
                found = true;
                ret = double.Parse(s);
            } else if (typeof(T).IsEnum) {
                found = true;
                ret = Enum.Parse(typeof(T), s);
            } else if (typeof(T).IsClass) {
                found = true;
                ConstructorInfo cinfo = typeof(T).GetConstructor(new[] {typeof(string)});
                if (cinfo != null) {
                    ret = cinfo.Invoke(new object[] {s});
                } else {
                    throw new NotImplementedException("No constructor that takes a string");
                }
            } 

            if (found) {
                return (T) ret;
            }
            throw new NotImplementedException();
        }
    }
}