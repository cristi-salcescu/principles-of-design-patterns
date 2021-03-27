namespace Insurance
{
    public class Insurer2 : IInsurerPrice
    {
        public PolicyPrice ComputePrice(PolicyForm data)
        {
            return new PolicyPrice()
            {
                InsurerName = "Insurer2",
                Price = 110
            };
        }
    }
}
