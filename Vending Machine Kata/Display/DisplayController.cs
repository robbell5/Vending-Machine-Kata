using System;
using System.Windows.Forms;

namespace Vending_Machine_Kata.Display
{
    public class DisplayController : IDisplayController
    {
        public TextBox Display { get; }

        private const string IntialMessage = "INSERT COINS";

        public DisplayController(TextBox displayTextBox)
        {
            Display = displayTextBox;
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
    }
}