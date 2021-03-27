using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Exports
{
    public interface IExportGenerator
    {
        byte[] Generate(DataTable data);
    }
}
