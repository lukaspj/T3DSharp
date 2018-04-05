using System;
using System.Runtime.InteropServices;

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
    }
}