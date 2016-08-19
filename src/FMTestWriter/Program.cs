using System;
using Config.NET;
using System.IO;

namespace FMTestWriter {
    class Program {
        static void Main(string[] args) {
            var file = new ConfigFile("", "fmSettings");
            file.Load();
            string one = file.GetConfig("fileOne");
            string two = file.GetConfig("fileTwo");
            string three = file.GetConfig("fileThree");

            string[] input = Console.ReadLine().Split(' ');

            if (input[0] == "!1") {
                //Write file one
                using (var writer = new StreamWriter(one, false)) {
                    writer.Write("FileOne");
                }

                
            }
            else if (input[0] == "!2") {
                using (var writer = new StreamWriter(two, false)) {
                    writer.Write("FileTwo");
                }
                //Write file two
            }
            else if (input[0] == "!3") {
                using (var writer = new StreamWriter(three, false)) {
                    writer.Write("FileThree");
                }
                //Write file three
            }
            Console.Read();
        }
    }
}
