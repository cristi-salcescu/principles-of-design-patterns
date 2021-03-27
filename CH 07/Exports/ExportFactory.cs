using System;
using System.Collections.Generic;
using System.Text;

namespace Exports
{
    public class ExportFactory : IExportFactory
    {
        public IExportGenerator GetInstance(string exportType)
        {
            switch (exportType)
            {
                case "csv": return new CsvExportGenerator();
                case "excel": return new ExcelExportGenerator();
                case "pdf": return new PdfExportGenerator();
            }

            throw new Exception($"{exportType} is not supported");
        } 
    }
}
