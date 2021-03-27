using System;

namespace IntegrationExternalDevice
{
    class Program
    {
        static void Main(string[] args)
        {
            var deviceGateway = new DeviceGateway();
            var productService = new ProductService(deviceGateway);

            var productInfo = new ProductInfo()
            {
                Code = "0001",
                Size = 1
            };
            productService.CreateProduct(productInfo);

            Console.ReadKey();
        }
    }
}
