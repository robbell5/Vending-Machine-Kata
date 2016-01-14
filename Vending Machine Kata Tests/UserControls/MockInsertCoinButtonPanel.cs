using System.Windows.Forms;
using Vending_Machine_Kata.UserControls;

namespace Vending_Machine_Kata_Tests.UserControls
{
    class MockInsertCoinButtonPanel : IInsertCoinButtonPanel
    {
        public Button InsertPennyButton { get; } = new Button();
        public Button InsertNickelButton { get; } = new Button();
        public Button InsertDimeButton { get; } = new Button();
        public Button InsertQuarterButton { get; } = new Button();
    }
}
