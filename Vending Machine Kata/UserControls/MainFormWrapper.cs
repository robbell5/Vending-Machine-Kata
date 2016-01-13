using System.Windows.Forms;

namespace Vending_Machine_Kata.UserControls
{
    public class MainFormWrapper
    {
        public Form MainForm { get; private set; }
        public IInsertCoinButtonPanel InsertCoinButtonPanel { get; private set; }

        public MainFormWrapper(Form form)
        {
            MainForm = form;
            InsertCoinButtonPanel = new InsertCoinButtonPanel(null, null, null, null);
        }
    }
}