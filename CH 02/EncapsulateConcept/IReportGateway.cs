using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulateConcept
{
    public interface IReportGateway
    {
        byte[] RenderReport(string reportPath);
    }
}
