using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamentals
{
    public class ConsoleLogger : BaseLogger
    {
        public override void Log(string message)
        {
            Console.WriteLine(FormatMessage(message));
        }

        public void Log(string logType, string message)
        {
            Console.WriteLine(string.Format("{0}-{1}", 
                        logType, 
                        FormatMessage(message)));
        }
    }
}
