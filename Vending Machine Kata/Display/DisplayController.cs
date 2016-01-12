using System;
using System.Windows.Forms;
using Vending_Machine_Kata.MonetaryMechanism;

namespace Vending_Machine_Kata.Display
{
    public class DisplayController : IDisplayController, ICoinPurseObserver
    {
        public TextBox Display { get; }
        public ICoinPurse CoinPurse { get; }

        private const string IntialMessage = "INSERT COINS";

        public DisplayController(TextBox displayTextBox, ICoinPurse coinPurse)
        {
            Display = displayTextBox;
            CoinPurse = coinPurse;
            CoinPurse.RegisterObserver(this);
            FormatDisplay();
        }

        private void FormatDisplay()
        {
            Display.Multiline = true;
            DisplayMessage(IntialMessage);
        }

        private void DisplayMessage(string message)
        {
            Display.Text = message + Environment.NewLine;
        }

        public void CoinPurseUpdated()
        {
        }
    }
}