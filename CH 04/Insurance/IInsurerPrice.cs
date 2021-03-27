namespace Insurance
{
    public interface IInsurerPrice
    {
        PolicyPrice ComputePrice(PolicyForm data);
    }
}
