using System;
using System.Collections.Generic;
using System.Text;

namespace IntegrationExternalDevice
{
    public class DeviceGateway : IDeviceGateway
    {
        private ExternalLibrary externalLibrary;

        public DeviceGateway()
        {
            this.externalLibrary = new ExternalLibrary();
        }

        public void CreateProduct(ProductInfo productInfo)
        {
            externalLibrary.ProcessProduct(productInfo.Code, productInfo.Size);
        }
    }
}
