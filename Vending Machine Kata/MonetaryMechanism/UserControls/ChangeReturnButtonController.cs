using System.Windows.Forms;

namespace Vending_Machine_Kata.MonetaryMechanism.UserControls
{
    public class ChangeReturnButtonController
    {
        public Button Button { get; set; }
        public ICoinPurse CoinPurse { get; set; }
        public ICoinReturn CoinReturn { get; set; }

        public ChangeReturnButtonController(Button changeReturnButton, ICoinPurse coinPurse, ICoinReturn coinReturn)
        {
            Button = changeReturnButton;
            CoinPurse = coinPurse;
            CoinReturn = coinReturn;
        }
    }
}