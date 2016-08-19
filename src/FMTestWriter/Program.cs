using System;
using System.Collections.Generic;
using Config.NET;
using System.IO;
using System.Timers;

namespace FMTestWriter {
    class Program {
        public static Dictionary<string, string> files = new Dictionary<string, string>()
        {
            {"file1",@"B:\Users\Dev\Desktop\New Text Document - Copy.txt"},
            {"file2",@"B:\Users\Dev\Desktop\New Text Document - Copy (2).txt" },
            {"file3",@"B:\Users\Dev\Desktop\New Text Document - Copy (3).txt"},
            {"file4",@"B:\Users\Dev\Desktop\New Text Document - Copy (4).txt"},
            {"file5",@"B:\Users\Dev\Desktop\New Text Document - Copy (5).txt"},
            {"file6", @"B:\Users\Dev\Desktop\New Text Document - Copy (6).txt"}
        };
        static void Main(string[] args) {





            //var file = new ConfigFile("", "fmSettings");
            //file.Load();
            //string one = file.GetConfig("fileOne");
            //string two = file.GetConfig("fileTwo");
            //string three = file.GetConfig("fileThree");

            //string[] input = Console.ReadLine().Split(' ');

            //if (input[0] == "!1") {
            //    //Write file one
            //    using (var writer = new StreamWriter(one, false)) {
            //        writer.Write("FileOne");
            //    }


            //}
            //else if (input[0] == "!2") {
            //    using (var writer = new StreamWriter(two, false)) {
            //        writer.Write("FileTwo");
            //    }
            //    //Write file two
            //}
            //else if (input[0] == "!3") {
            //    using (var writer = new StreamWriter(three, false)) {
            //        writer.Write("FileThree");
            //    }
            //    //Write file three
            //}
            Timer tim = new Timer(TimeSpan.FromSeconds(15).TotalMilliseconds);
            tim.Enabled = true;
            tim.Elapsed += Tim_Elapsed;
            tim.Start();
            Console.Read();
        }

        private static void Tim_Elapsed(object sender, ElapsedEventArgs e) {
            foreach (var file in files) {
                Console.WriteLine($"Writing {file.Key} to {file.Value}");
                using (var writer = new StreamWriter(file.Value, false)) {                    writer.Write(file.Key);                }
            }
        }
    }
}
