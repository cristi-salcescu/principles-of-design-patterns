using System;
using System.Collections.Generic;
using System.Text;

namespace InversionOfControl
{
    public class Service : IService
    {
        private IDataAccess dataAccess;

        public Service(IDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        public void Remove(int id)
        {
            Console.WriteLine("Process in Service");
            this.dataAccess.Remove(id);
        }
    }
}
