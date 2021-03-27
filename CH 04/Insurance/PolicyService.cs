using System;
using System.Collections.Generic;
using System.Linq;

namespace Insurance
{
    public class PolicyService
    {
        private IEnumerable<IInsurerPrice> insurers;

        public PolicyService(IEnumerable<IInsurerPrice> insurers)
        {
            this.insurers = insurers;
        }

        public IEnumerable<PolicyPrice> ComputePrices(PolicyForm data)
        {
            return insurers.Select(i => i.ComputePrice(data)).ToList();
        }
    }
}
