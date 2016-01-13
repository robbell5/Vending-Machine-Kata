using System.Windows.Forms;

namespace Vending_Machine_Kata.UserControls
{
    public class MainFormWrapper
    {
        public Form MainForm { get; private set; }

        public MainFormWrapper(Form form)
        {
            MainForm = form;
        }
    }
}