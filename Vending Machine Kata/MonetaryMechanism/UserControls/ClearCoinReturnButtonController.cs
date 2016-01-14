namespace Vending_Machine_Kata.MonetaryMechanism.UserControls
{
    public class ClearCoinReturnButtonController
    {
        public ICoinReturn CoinReturn { get; }

        public ClearCoinReturnButtonController(ICoinReturn coinReturn)
        {
            CoinReturn = coinReturn;
        }
    }
}