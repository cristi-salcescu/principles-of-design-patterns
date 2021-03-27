using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Exports
{
    public class ExcelExportGenerator : IExportGenerator
    {
        public byte[] Generate(DataTable data)
        {
            Console.WriteLine("Excel");
            return new byte[0];
        }
    }
}
