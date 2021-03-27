using System;
using System.Collections.Generic;
using System.Text;

namespace IntegrationExternalDevice
{
    public class ProductService
    {
        private IDeviceGateway deviceGateway;

        public ProductService(IDeviceGateway deviceGateway)
        {
            this.deviceGateway = deviceGateway;
        }

        public void CreateProduct(ProductInfo productInfo)
        {
            /* code */
            deviceGateway.CreateProduct(productInfo);
        }
    }
}
