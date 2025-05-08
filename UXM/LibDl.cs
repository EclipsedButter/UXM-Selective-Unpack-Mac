using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;

namespace UXM
{
    public static class LibDl
    {
#if OS_MAC
        [DllImport("libdl.dylib", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
#elif OS_LINUX
        [DllImport("libdl.so", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
#endif
        static extern IntPtr dlopen(string filename, int flags);

#if OS_MAC
        [DllImport("libdl.dylib", CallingConvention = CallingConvention.StdCall)]
#elif OS_LINUX
        [DllImport("libdl.so", CallingConvention = CallingConvention.StdCall)]
#endif
        static extern IntPtr dlerror();

#if OS_MAC
        [DllImport("libdl.dylib", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
#elif OS_LINUX
        [DllImport("libdl.so", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
#endif
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool dlclose(IntPtr handle);

        public const int RTLD_LAZY = 0x00001;  // Lazy function call binding
        public const int RTLD_NOW = 0x00002;   // Immediate function call binding

        public static string GetLastError()
        {
            return Marshal.PtrToStringAnsi(dlerror());
        }

        public static IntPtr LoadLibrary(string path)
        {
            return dlopen(path, RTLD_NOW);
        }

        public static bool FreeLibrary(IntPtr handle)
        {
            return dlclose(handle);
        }
    }

}