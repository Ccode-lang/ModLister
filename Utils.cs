using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModLister
{
    internal class Utils
    {
        public static string LogLocation;

        public static void Init(string location)
        {
            LogLocation = location;
            if (File.Exists(LogLocation))
            {
                File.Delete(LogLocation);
            }
            using (StreamWriter sw = File.AppendText(LogLocation))
            {
                sw.WriteLine("Mod list:");
            }
        }
        public static void PrintToLog(string line)
        {
            using (StreamWriter sw = File.AppendText(LogLocation))
            {
                sw.WriteLine(line);
            }
        }
    }
}
