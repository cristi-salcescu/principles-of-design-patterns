using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Exports
{
    public class CsvExportGenerator : IExportGenerator
    {
        public byte[] Generate(DataTable data)
        {
            Console.WriteLine("Csv");
            return new byte[0];
        }
    }
}
