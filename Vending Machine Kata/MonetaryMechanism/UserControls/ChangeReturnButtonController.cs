using System.Windows.Forms;

namespace Vending_Machine_Kata.MonetaryMechanism.UserControls
{
    public class ChangeReturnButtonController
    {
        public Button Button { get; set; }

        public ChangeReturnButtonController(Button changeReturnButton)
        {
            Button = changeReturnButton;
        }
    }
}