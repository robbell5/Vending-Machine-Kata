namespace Vending_Machine_Kata.MonetaryMechanism.Coin
{
    public class CoinFactory : ICoinFactory
    {
        public ICoin BuildCoin(CoinSize coinSize)
        {
            switch (coinSize)
            {
                case CoinSize.SMALL:
                    return new Penny();
                case CoinSize.TINY:
                    return new Dime();
                case CoinSize.MEDIUM:
                    return new Nickel();
                case CoinSize.LARGE:
                    return new Quarter();
                default:
                    break;
            }

            return new NullCoin();
        }
    }
}
