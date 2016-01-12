namespace Vending_Machine_Kata.MonetaryMechanism.Coin
{
    public class CoinFactory : ICoinFactory
    {
        public ICoin BuildCoin(CoinPhysicalProperties.SizeAndWeight sizeAndWeight)
        {
            switch (sizeAndWeight)
            {
                case CoinPhysicalProperties.SizeAndWeight.SMALL:
                    return new Dime();
                case CoinPhysicalProperties.SizeAndWeight.MEDIUM:
                    return new Nickel();
                case CoinPhysicalProperties.SizeAndWeight.LARGE:
                    return  new Quarter();
            } 

            return new NullCoin();
        }
    }
}
