using System;
using System.Collections.Generic;
using System.Text;

namespace IntegrationExternalDevice
{
    public class FakeDeviceGateway : IDeviceGateway
    {
        public void CreateProduct(ProductInfo productInfo)
        {
            Console.WriteLine("create product");
        }
    }
}
