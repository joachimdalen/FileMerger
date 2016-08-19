using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMerger {
    internal class FileMergerSettings {
        public static Dictionary<string, string> Files { get; set; }

        public static Dictionary<string, string> FileCache { get; set; }
        public static string FileOutput { get; set; }
        public static bool StartOnStartup { get; set; }
        public static bool MinimizeToTray { get; set; }
        //public static bool IsLocked = false;
        public static string OutputFormat { get; set; }
        public static double RefreshInterval { get; set; }

    }
}
