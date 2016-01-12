using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Vending_Machine_Kata.MonetaryMechanism.Coin;

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

            Button.Click += ButtonEventListener;
        }

        private void ButtonEventListener(object sender, EventArgs eventArgs)
        {
            List<ICoin> coinsFromPurse = CoinPurse.Clear();

            foreach (ICoin coinFromPurse in coinsFromPurse)
                CoinReturn.AddCoin(coinFromPurse);
        }
    }
}