using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SecretSound.Core
{
    public class Keeper
    {
        private const string DllName = "Wave.dll";

        //回调函数的委托
        public delegate void ProgressCallback(int progress);

        [DllImport("Wave.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "Mix")]
        public static unsafe extern int Mix(
            string pSourceWaveFile,
            string pSourceFile,
            string pOutputFile,
            int bitsNum,
            ProgressCallback DisplayProgress);

        [DllImport("Wave.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "Extract")]
        public static unsafe extern int Extract(
            string pSourceWaveFile,
            string pOutputFile,
            ProgressCallback DisplayProgress);

        [DllImport("Wave.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "GetErrorMessage")]
        public static unsafe extern void GetErrorMessage(int nErrorIndex, StringBuilder pErrorMessage);

        public static bool CheckDll()
        {
            string dir = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
            string fname_AppleDll = Path.Combine(dir, DllName);

            if (File.Exists(fname_AppleDll))
            {
                Environment.SetEnvironmentVariable("Path", string.Join(";", new String[] { Environment.GetEnvironmentVariable("Path"), dir }));

                return true;
            }
            return false;
        }

        public static bool CheckFile(string filepath)
        {
            if (File.Exists(filepath))
            {
                return true;
            }
            return false;
        }

        public static void AllExit()
        {
            Environment.Exit(0);
        }


    }
}
