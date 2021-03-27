using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Exports
{
    public class PdfExportGenerator : IExportGenerator
    {
        public byte[] Generate(DataTable data)
        {
            Console.WriteLine("Pdf");
            return new byte[0];
        }
    }
}
