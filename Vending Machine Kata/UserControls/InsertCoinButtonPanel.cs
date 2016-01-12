using System.Windows.Forms;

namespace Vending_Machine_Kata.UserControls
{
    public class InsertCoinButtonPanel
    {
        public Button InsertPennyButton { get; }
        public Button InsertNickelButton { get; }
        public Button InsertDimeButton { get; }
        public Button InsertQuarterButton { get; }

        public InsertCoinButtonPanel(Button insertPennyButton, Button insertNickelButton, Button insertDimeButton, Button insertQuarterButton)
        {
            InsertPennyButton = insertPennyButton;
            InsertNickelButton = insertNickelButton;
            InsertDimeButton = insertDimeButton;
            InsertQuarterButton = insertQuarterButton;
        }
    }
}