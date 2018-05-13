using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualLoopPedal
{
    class Logger
    {
        static bool cleared = false;

        public static void Clear()
        {
            cleared = true;
            StreamWriter writer = new StreamWriter("log.txt");
            writer.Close();
            Log("Starting log");
        }

        public static void Log(string message)
        {
            if (!cleared)
                Clear();

            using (StreamWriter writer = new StreamWriter("log.txt", true))
            {
                writer.WriteLine(message);
            }
        }
    }
}
