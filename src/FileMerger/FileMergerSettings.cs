using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMerger {
    internal class FileMergerSettings {
        public static string FileOne { get; set; }
        public static string FileTwo { get; set; }
        public static string FileThree { get; set; }
        public static string FileOutput { get; set; }
        public static bool StartOnStartup { get; set; }
        public static bool MinimizeToTray { get; set; }
        //public static bool IsLocked = false;
        public static string OutputFormat { get; set; }
        public static string FileOneCache { get; set; }
        public static string FileTwoCache { get; set; }
        public static string FileThreeCache { get; set; }
        public static double RefreshInterval { get; set; }

    }
}
