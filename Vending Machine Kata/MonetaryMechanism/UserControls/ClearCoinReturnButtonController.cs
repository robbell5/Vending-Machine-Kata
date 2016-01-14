using System;
using System.Windows.Forms;

namespace Vending_Machine_Kata.MonetaryMechanism.UserControls
{
    public class ClearCoinReturnButtonController
    {
        public ICoinReturn CoinReturn { get; }
        public Button Button { get; }

        public ClearCoinReturnButtonController(Button clearCoinReturnButton, ICoinReturn coinReturn)
        {
            CoinReturn = coinReturn;
            Button = clearCoinReturnButton;
            Button.Click += ButtonEventListener;
        }

        private void ButtonEventListener(object sender, EventArgs eventArgs)
        {
            CoinReturn.Clear();
        }
    }
}