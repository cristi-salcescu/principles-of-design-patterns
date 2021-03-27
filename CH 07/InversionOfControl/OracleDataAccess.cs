using System;
using System.Collections.Generic;
using System.Text;

namespace InversionOfControl
{
    public class OracleDataAccess : IDataAccess
    {
        public void Remove(int id)
        {
            Console.WriteLine("Oracle: Remove id: {0}", id);
        }
    }
}
