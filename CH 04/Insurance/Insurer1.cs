namespace Insurance
{
    public class Insurer1 : IInsurerPrice
    {
        public PolicyPrice ComputePrice(PolicyForm data)
        {
            return new PolicyPrice()
            {
                InsurerName = "Insurer1",
                Price = 100
            };
        }
    }
}
