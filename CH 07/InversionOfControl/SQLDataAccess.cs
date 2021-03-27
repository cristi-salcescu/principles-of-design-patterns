using System;
using System.Collections.Generic;
using System.Text;

namespace InversionOfControl
{
    public class SQLDataAccess : IDataAccess
    {
        public void Remove(int id)
        {
            Console.WriteLine("SQL: Remove id: {0}", id);
        }
    }
}
