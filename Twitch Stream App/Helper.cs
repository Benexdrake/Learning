using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Twitch_Stream_App
{
    internal class Helper
    {
        public static void Log(string text)
        {
            string path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\log.txt";
            string pfad = "C:\\Temp\\datei.txt";

            FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(text);

            sw.Close();
            fs.Close();
        }
    }
}
