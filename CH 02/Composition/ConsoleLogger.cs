using System;
using System.Collections.Generic;
using System.Text;

namespace Composition
{
    public class ConsoleLogger
    {
        private LogFormatter logFormatter;

        public ConsoleLogger(LogFormatter logFormatter)
        {
            this.logFormatter = logFormatter;
        }

        public void Log(string message)
        {
            Console.WriteLine(logFormatter.FormatMessage(message));
        }
    }
}
