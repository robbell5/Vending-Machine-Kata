using Vending_Machine_Kata.MonetaryMechanism.Coin;

namespace Vending_Machine_Kata_Tests.MonetaryMechanism.Coin
{
    public class MockCoin : ICoin
    {
        public decimal Value => ValueToReturn;
        public decimal ValueToReturn { get; set; } = 0;

        public MockCoin()
        {
        }
    }
}
