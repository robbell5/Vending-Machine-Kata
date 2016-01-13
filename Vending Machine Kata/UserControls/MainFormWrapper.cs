using System.Linq;
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
            InsertCoinButtonPanel = new InsertCoinButtonPanel(GetButtonFromForm("InsertPennyButton"), null, null, null);
        }

        private Button GetButtonFromForm(string controlName)
        {
            foreach (
                Control control in
                    MainForm.Controls.Cast<Control>()
                        .Where(control => control.GetType() == typeof (Button) && control.Name == controlName))
                return (Button) control;

            return new Button();
        }
    }
}