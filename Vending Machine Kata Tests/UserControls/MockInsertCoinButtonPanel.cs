using System.Windows.Forms;
using Vending_Machine_Kata.UserControls;

namespace Vending_Machine_Kata_Tests.UserControls
{
    class MockInsertCoinButtonPanel : IInsertCoinButtonPanel
    {
        public Button InsertPennyButton { get; }
        public Button InsertNickelButton { get; }
        public Button InsertDimeButton { get; }
        public Button InsertQuarterButton { get; }

        public MockInsertCoinButtonPanel()
        {
            InsertPennyButton = new Button();
            InsertNickelButton = new Button();
            InsertDimeButton = new Button();
            InsertQuarterButton = new Button();
        }
    }
}
