using System;
using System.Collections.Generic;
using System.Linq;

namespace Insurance
{
    class Program
    {
        static void Main(string[] args)
        {
            var insurers = new List<IInsurerPrice>();
            insurers.Add(new Insurer1());
            insurers.Add(new Insurer2());
            insurers.Add(new Insurer3());

            var policyService = new PolicyService(insurers);

            var policy = new PolicyForm()
            {
                Name = "Cristian",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddYears(1)
            };

            var prices = policyService.ComputePrices(policy);
            prices.ToList().ForEach(LogPrice);

            Console.ReadKey();
        }

        static void LogPrice(PolicyPrice price)
        {
            Console.WriteLine($"{price.InsurerName} {price.Price}");
        }
    }
}
