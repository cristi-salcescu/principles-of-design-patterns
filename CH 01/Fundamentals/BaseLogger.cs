using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamentals
{
    public abstract class BaseLogger
    {
        public abstract void Log(string message);

        protected string FormatMessage(string message)
        {
            return string.Format("{0} {1}: {2}", 
                DateTime.Now.ToLongTimeString(),
                DateTime.Now.ToShortDateString(),
                message);
        }
    }
}
