using System;
using System.Data;

namespace Exports
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new ReflectionExportFactory();
            var exportGenerator = factory.GetInstance("excel");
            var data = new DataTable();
            var report = exportGenerator.Generate(data);
            Console.ReadKey();
        }
    }
}
