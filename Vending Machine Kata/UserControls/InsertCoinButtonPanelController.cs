using System;
using System.Collections.Generic;
using Vending_Machine_Kata.MonetaryMechanism;
using Vending_Machine_Kata.MonetaryMechanism.Coin;

namespace Vending_Machine_Kata.UserControls
{
    public class InsertCoinButtonPanelController
    {
        public IInsertCoinButtonPanel InsertCoinButtonPanel { get; private set; }
        public ICoinAccepter CoinAccepter { get; private set; }

        public InsertCoinButtonPanelController(IInsertCoinButtonPanel insertCoinButtonPanel, ICoinAccepter coinAccepter)
        {
            InsertCoinButtonPanel = insertCoinButtonPanel;
            CoinAccepter = coinAccepter;

            InsertCoinButtonPanel.InsertPennyButton.Click += InsertPennyButtonEventListener;
        }

        private void InsertPennyButtonEventListener(object sender, EventArgs eventArgs)
        {
            CoinAccepter.Accept(CoinSize.SMALL);
        }
    }
}