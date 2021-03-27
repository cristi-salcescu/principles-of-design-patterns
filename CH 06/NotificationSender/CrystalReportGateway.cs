using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulateConcept
{
    public class CrystalReportGateway : IReportGateway
    {
        public byte[] GenerateReport(string reportPath)
        {
            byte[] content = null;
            Console.WriteLine("Crystal Reports");

            return content;
        }
    }
}
