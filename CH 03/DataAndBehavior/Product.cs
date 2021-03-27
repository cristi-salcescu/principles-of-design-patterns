using System;
using System.Collections.Generic;
using System.Text;

namespace DataAndBehavior
{
    public class Product : IID
    {
        public int ID { get; }

        public string Code { get; }

        public string Name { get; }

        public Product(int id, string code, string name)
        {
            ID = id;
            Code = code;
            Name = name;
        }
    }
}
