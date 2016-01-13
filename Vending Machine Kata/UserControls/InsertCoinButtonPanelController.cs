namespace Vending_Machine_Kata.UserControls
{
    public class InsertCoinButtonPanelController
    {
        public IInsertCoinButtonPanel InsertCoinButtonPanel { get; private set; }

        public InsertCoinButtonPanelController(IInsertCoinButtonPanel insertCoinButtonPanel)
        {
            InsertCoinButtonPanel = insertCoinButtonPanel;
        }
    }
}