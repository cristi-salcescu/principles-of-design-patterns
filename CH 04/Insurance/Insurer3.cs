namespace Insurance
{
    public class Insurer3 : IInsurerPrice
    {
        public PolicyPrice ComputePrice(PolicyForm data)
        {
            return new PolicyPrice()
            {
                InsurerName = "Insurer3",
                Price = 120
            };
        }
    }
}
