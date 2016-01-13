using Vending_Machine_Kata.MonetaryMechanism;

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
        }
    }
}