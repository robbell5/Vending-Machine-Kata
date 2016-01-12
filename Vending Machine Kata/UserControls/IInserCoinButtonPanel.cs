using System.Windows.Forms;

namespace Vending_Machine_Kata.UserControls
{
    public interface IInserCoinButtonPanel
    {
        Button InsertPennyButton { get; }
        Button InsertNickelButton { get; }
        Button InsertDimeButton { get; }
        Button InsertQuarterButton { get; }
    }
}