using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Fundamentals
{
    public class FileLogger
    {
        private string logFile = "log.txt";

        public void Log(string message)
        {
            using (StreamWriter sw = File.AppendText(logFile))
            {
                sw.WriteLine(message);
            }
        }
    }
}
