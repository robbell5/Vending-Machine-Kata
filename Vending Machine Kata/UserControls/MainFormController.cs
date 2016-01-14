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
        private const string DisplayTextBoxName = "DisplayTextBox";
        private const string ChangeReturnButtonName = "ChangeReturnButton";
        private const string InsertPennyButtonName = "InsertPennyButton";
        private const string InsertNickelButtonName = "InsertNickelButton";
        private const string InsertDimeButtonName = "InsertDimeButton";
        private const string InsertQuarterButtonName = "InsertQuarterButton";
        private const string CoinReturnDisplayTextBoxName = "CoinReturnDisplayTextBox";
        private const string ClearCoinReturnButtonName = "ClearCoinReturnButton";

        public Form MainForm { get; }
        public IInsertCoinButtonPanel InsertCoinButtonPanel { get; private set; }
        public ICoinPurse CoinPurse { get; }
        public ICoinReturn CoinReturn { get; }
        public ICoinAccepter CoinAccepter { get; }
        public ICoinFactory CoinFactory { get; }
        public VendingDisplayController DisplayController { get; }
        public ReturnChangeButtonController ReturnChangeButtonController { get; }
        public InsertCoinButtonPanelController InsertCoinButtonPanelController { get; }
        public CoinReturnDisplayController CoinReturnDisplayController { get; private set; }
        public ClearCoinReturnButtonController ClearCoinReturnButtonController { get; private set; }

        public MainFormController(Form form)
        {
            MainForm = form;

            CoinPurse = new CoinPurse();
            CoinReturn = new CoinReturn();
            CoinFactory = new CoinFactory();

            CoinAccepter = new CoinAccepter(CoinFactory, CoinPurse, CoinReturn);

            DisplayController = new VendingDisplayController(GetTextBoxFromForm(DisplayTextBoxName), CoinPurse);

            ReturnChangeButtonController = new ReturnChangeButtonController(GetButtonFromForm(ChangeReturnButtonName),
                CoinPurse, CoinReturn);

            InsertCoinButtonPanel = new InsertCoinButtonPanel(GetButtonFromForm(InsertPennyButtonName),
                GetButtonFromForm(InsertNickelButtonName),
                GetButtonFromForm(InsertDimeButtonName),
                GetButtonFromForm(InsertQuarterButtonName));

            InsertCoinButtonPanelController = new InsertCoinButtonPanelController(InsertCoinButtonPanel, CoinAccepter);

            CoinReturnDisplayController =
                new CoinReturnDisplayController(GetTextBoxFromForm(CoinReturnDisplayTextBoxName), CoinReturn);

            ClearCoinReturnButtonController =
                new ClearCoinReturnButtonController(GetButtonFromForm(ClearCoinReturnButtonName), CoinReturn);
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