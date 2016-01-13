using System.Windows.Forms;
using Vending_Machine_Kata.MonetaryMechanism;

namespace Vending_Machine_Kata.Display
{
    public class CoinReturnDisplayController : IDisplayController, ICoinReturnObserver
    {
        public TextBox Display { get; }
        public ICoinReturn CoinReturn { get; set; }

        public CoinReturnDisplayController(TextBox displayTextBox, ICoinReturn coinReturn)
        {
            Display = displayTextBox;
            CoinReturn = coinReturn;
            CoinReturn.RegisterObserver(this);

            UpdateDisplayWithCoinReturnValue();
        }

        public void CoinReturnUpdated()
        {
            UpdateDisplayWithCoinReturnValue();
        }

        private static string FormatValueToMoney(decimal value)
        {
            return $"{value:C}";
        }

        private void UpdateDisplayWithCoinReturnValue()
        {
            Display.Text = FormatValueToMoney(CoinReturn.AmountAvailable);
        }
    }
}