namespace Vending_Machine_Kata.MonetaryMechanism.Coin
{
    public class CoinFactory : ICoinFactory
    {
        public ICoin BuildCoin(CoinSize coinSize)
        {
            switch (coinSize)
            {
                case CoinSize.Small:
                    return new Penny();
                case CoinSize.Tiny:
                    return new Dime();
                case CoinSize.Medium:
                    return new Nickel();
                case CoinSize.Large:
                    return new Quarter();
                default:
                    break;
            }

            return new NullCoin();
        }
    }
}
