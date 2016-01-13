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
            InsertCoinButtonPanel.InsertNickelButton.Click += InsertNickelButtonEventListener;
            InsertCoinButtonPanel.InsertDimeButton.Click += InsertDimeButtonEventListener;
            InsertCoinButtonPanel.InsertQuarterButton.Click += InsertQuarterButtonEventListener;
        }

        private void InsertPennyButtonEventListener(object sender, EventArgs eventArgs)
        {
            CoinAccepter.Accept(CoinSize.SMALL);
        }

        private void InsertNickelButtonEventListener(object sender, EventArgs eventArgs)
        {
            CoinAccepter.Accept(CoinSize.MEDIUM);
        }

        private void InsertDimeButtonEventListener(object sender, EventArgs eventArgs)
        {
            CoinAccepter.Accept(CoinSize.TINY);
        }

        private void InsertQuarterButtonEventListener(object sender, EventArgs eventArgs)
        {
            CoinAccepter.Accept(CoinSize.LARGE);
        }
    }
}