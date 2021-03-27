using System;
using System.Collections.Generic;
using System.Text;

namespace Exports
{
    public interface IExportFactory
    {
        IExportGenerator GetInstance(string type);
    }
}
