using System.Windows.Forms;

namespace Vending_Machine_Kata.Display
{
    public class DisplayController : IDisplayController
    {
        public TextBox Display { get; }

        public DisplayController(TextBox displayTextBox)
        {
            Display = displayTextBox;
            FormatDisplay();
        }

        private void FormatDisplay()
        {
            Display.Multiline = true;
        }
    }
}