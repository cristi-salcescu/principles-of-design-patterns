using System;
using System.Collections.Generic;
using System.Text;

namespace Export
{
    public interface IExport
    {
        byte[] Generate();
    }
}
