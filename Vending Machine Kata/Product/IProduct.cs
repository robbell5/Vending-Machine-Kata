namespace Vending_Machine_Kata.Product
{
    public interface IProduct
    {
        string DisplayName { get; }
        decimal Value { get; }
    }
}