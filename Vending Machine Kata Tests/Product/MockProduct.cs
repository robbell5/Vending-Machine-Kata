using Vending_Machine_Kata.Product;

namespace Vending_Machine_Kata_Tests.Product
{
    public class MockProduct : IProduct
    {
        public string DisplayName => "Mock Product";
        public decimal Value => 0;
    }
}