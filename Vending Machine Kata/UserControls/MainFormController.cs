using System.Linq;
using System.Windows.Forms;
using Vending_Machine_Kata.Display;
using Vending_Machine_Kata.MonetaryMechanism;
using Vending_Machine_Kata.MonetaryMechanism.Coin;
using Vending_Machine_Kata.MonetaryMechanism.UserControls;

namespace Vending_Machine_Kata.UserControls
{
    public class MainFormController
    {
        public Form MainForm { get; }
        public IInsertCoinButtonPanel InsertCoinButtonPanel { get; private set; }
        public ICoinPurse CoinPurse { get; }
        public ICoinReturn CoinReturn { get; }
        public ICoinAccepter CoinAccepter { get; }
        public ICoinFactory CoinFactory { get; }
        public VendingDisplayController DisplayController { get; }
        public ChangeReturnButtonController ChangeReturnButtonController { get; }
        public InsertCoinButtonPanelController InsertCoinButtonPanelController { get; }

        public MainFormController(Form form)
        {
            MainForm = form;

            CoinPurse = new CoinPurse();
            CoinReturn = new CoinReturn();
            CoinFactory = new CoinFactory();

            CoinAccepter = new CoinAccepter(CoinFactory, CoinPurse, CoinReturn);

            DisplayController = new VendingDisplayController(GetTextBoxFromForm("DisplayTextBox"), CoinPurse);

            ChangeReturnButtonController = new ChangeReturnButtonController(GetButtonFromForm("ChangeReturnButton"),
                CoinPurse, CoinReturn);

            InsertCoinButtonPanel = new InsertCoinButtonPanel(GetButtonFromForm("InsertPennyButton"),
                GetButtonFromForm("InsertNickelButton"),
                GetButtonFromForm("InsertDimeButton"),
                GetButtonFromForm("InsertQuarterButton"));

            InsertCoinButtonPanelController = new InsertCoinButtonPanelController(InsertCoinButtonPanel, CoinAccepter);
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

        private TextBox GetTextBoxFromForm(string controlName)
        {
            foreach (
                Control control in
                    MainForm.Controls.Cast<Control>()
                        .Where(control => control.GetType() == typeof(TextBox) && control.Name == controlName))
                return (TextBox)control;

            return new TextBox();
        }
    }
}