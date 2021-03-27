using System;
using System.Collections.Generic;
using System.Text;

namespace Composition
{
    public class LogFormatter
    {
        public string FormatMessage(string message)
        {
            return string.Format("{0} {1}: {2}",
                                 DateTime.Now.ToLongTimeString(),
                                 DateTime.Now.ToShortDateString(),
                                 message);
        }
    }
}
