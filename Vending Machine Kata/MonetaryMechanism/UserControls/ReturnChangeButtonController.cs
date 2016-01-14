using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Vending_Machine_Kata.MonetaryMechanism.Coin;

namespace Vending_Machine_Kata.MonetaryMechanism.UserControls
{
    public class ReturnChangeButtonController
    {
        public Button Button { get; set; }
        public ICoinPurse CoinPurse { get; set; }
        public ICoinReturn CoinReturn { get; set; }

        public ReturnChangeButtonController(Button changeReturnButton, ICoinPurse coinPurse, ICoinReturn coinReturn)
        {
            Button = changeReturnButton;
            CoinPurse = coinPurse;
            CoinReturn = coinReturn;
            Button.Click += ButtonEventListener;
        }

        private void ButtonEventListener(object sender, EventArgs eventArgs)
        {
            List<ICoin> coinsFromPurse = CoinPurse.Clear();
            coinsFromPurse.ForEach(coin => CoinReturn.AddCoin(coin));
        }
    }
}