using System;
using System.Collections.Generic;
using System.Text;

namespace IntegrationExternalDevice
{
    public interface IDeviceGateway
    {
        void CreateProduct(ProductInfo productInfo);
    }
}
