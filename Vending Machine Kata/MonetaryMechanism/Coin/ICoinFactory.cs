namespace Vending_Machine_Kata.MonetaryMechanism.Coin
{
    public interface ICoinFactory
    {
        ICoin BuildCoin(CoinPhysicalProperties.SizeAndWeight sizeAndWeight);
    }
}
