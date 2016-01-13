using System.Linq;
using System.Windows.Forms;
using Vending_Machine_Kata.MonetaryMechanism;
using Vending_Machine_Kata.MonetaryMechanism.Coin;

namespace Vending_Machine_Kata.UserControls
{
    public class MainFormWrapper
    {
        public Form MainForm { get; private set; }
        public IInsertCoinButtonPanel InsertCoinButtonPanel { get; private set; }
        public ICoinPurse CoinPurse { get; private set; }
        public ICoinReturn CoinReturn { get; private set; }
        public ICoinAccepter CoinAccepter { get; set; }
        public ICoinFactory CoinFactory { get; set; }

        public MainFormWrapper(Form form)
        {
            MainForm = form;

            CoinPurse = new CoinPurse();
            CoinReturn = new CoinReturn();
            CoinFactory = new CoinFactory();

            CoinAccepter = new CoinAccepter(CoinFactory, CoinPurse, CoinReturn);

            InsertCoinButtonPanel = new InsertCoinButtonPanel(GetButtonFromForm("InsertPennyButton"),
                GetButtonFromForm("InsertNickelButton"),
                GetButtonFromForm("InsertDimeButton"),
                GetButtonFromForm("InsertQuarterButton"));
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