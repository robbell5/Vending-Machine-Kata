using System.Windows.Forms;
using NUnit.Framework;
using Vending_Machine_Kata.Display;
using Vending_Machine_Kata.MonetaryMechanism;
using Vending_Machine_Kata.MonetaryMechanism.Coin;
using Vending_Machine_Kata.MonetaryMechanism.UserControls;
using Vending_Machine_Kata.UserControls;

namespace Vending_Machine_Kata_Tests.UserControls
{
    [TestFixture]
    public class MainFormControllerTest
    {
        [Test]
        public void TestBaseProperties()
        {
            Form expectedForm = new Form();
            MainFormController mainFormController = new MainFormController(expectedForm);

            Assert.AreSame(expectedForm, mainFormController.MainForm);
        }

        [Test]
        public void TestBuildsInsertCoinButtonPanel()
        {
            Form mainForm = new Form();
            MainFormController mainFormController = new MainFormController(mainForm);

            Assert.IsInstanceOf(typeof(IInsertCoinButtonPanel), mainFormController.InsertCoinButtonPanel);
        }

        [Test]
        public void TestBuildsInsertCoinButtonPanelWithCorrectInsertCoinButtons()
        {
            Form mainForm = new Form();

            Button expectedInsertPennyButton = new Button {Name = "InsertPennyButton"};
            Button expectedInsertNickelButton = new Button {Name = "InsertNickelButton"};
            Button expectedInsertDimeButton = new Button {Name = "InsertDimeButton"};
            Button expectedInsertQuaterButton = new Button {Name = "InsertQuarterButton"};

            mainForm.Controls.Add(expectedInsertPennyButton);
            mainForm.Controls.Add(expectedInsertNickelButton);
            mainForm.Controls.Add(expectedInsertDimeButton);
            mainForm.Controls.Add(expectedInsertQuaterButton);

            MainFormController mainFormController = new MainFormController(mainForm);

            IInsertCoinButtonPanel insertCoinButtonPanel = mainFormController.InsertCoinButtonPanel;

            Assert.AreSame(expectedInsertPennyButton, insertCoinButtonPanel.InsertPennyButton);
            Assert.AreSame(expectedInsertNickelButton, insertCoinButtonPanel.InsertNickelButton);
            Assert.AreSame(expectedInsertDimeButton, insertCoinButtonPanel.InsertDimeButton);
            Assert.AreSame(expectedInsertQuaterButton, insertCoinButtonPanel.InsertQuarterButton);
        }

        [Test]
        public void TestCorrectlyBuildsCoinPurse()
        {
            MainFormController mainFormController = new MainFormController(new Form());

            ICoinPurse coinPurse = mainFormController.CoinPurse;

            Assert.IsInstanceOf(typeof(ICoinPurse), coinPurse);
        }

        [Test]
        public void TestCorrectlyBuildsCoinReturn()
        {
            MainFormController mainFormController = new MainFormController(new Form());

            ICoinReturn coinPurse = mainFormController.CoinReturn;

            Assert.IsInstanceOf(typeof(ICoinReturn), coinPurse);
        }

        [Test]
        public void TestCorrectlyBuildsCoinFactory()
        {
            MainFormController mainFormController = new MainFormController(new Form());

            ICoinFactory coinFactory = mainFormController.CoinFactory;

            Assert.IsInstanceOf(typeof(ICoinFactory), coinFactory);
        }

        [Test]
        public void TestCorrectlyBuildsCoinAccepter()
        {
            MainFormController mainFormController = new MainFormController(new Form());

            ICoinAccepter coinAccepter = mainFormController.CoinAccepter;

            Assert.IsInstanceOf(typeof(ICoinAccepter), coinAccepter);
            Assert.AreSame(mainFormController.CoinFactory, coinAccepter.CoinFactory);
            Assert.AreSame(mainFormController.CoinPurse, coinAccepter.CoinPurse);
            Assert.AreSame(mainFormController.CoinReturn, coinAccepter.CoinReturn);
        }

        [Test]
        public void TestCorrectlyBuildsDisplayController()
        {
            Form mainForm = new Form();
            TextBox expectedDisplayTextBox = new TextBox();
            expectedDisplayTextBox.Name = "DisplayTextBox";
            mainForm.Controls.Add(expectedDisplayTextBox);

            MainFormController mainFormController = new MainFormController(mainForm);

            VendingDisplayController displayController = mainFormController.DisplayController;

            Assert.IsInstanceOf(typeof(VendingDisplayController), displayController);
            Assert.AreSame(expectedDisplayTextBox, displayController.Display);
            Assert.AreSame(mainFormController.CoinPurse, displayController.CoinPurse);
        }

        [Test]
        public void TestCorrectlyBuildsChangeReturnButtonController()
        {
            Form mainForm = new Form();
            Button expectedChangeReturnButton = new Button() {Name = "ChangeReturnButton"};

            mainForm.Controls.Add(expectedChangeReturnButton);
            MainFormController mainFormController = new MainFormController(mainForm);

            ReturnChangeButtonController returnChangeButtonController = mainFormController.ReturnChangeButtonController;

            Assert.IsInstanceOf(typeof(ReturnChangeButtonController), returnChangeButtonController);
            Assert.AreSame(expectedChangeReturnButton, returnChangeButtonController.Button);
            Assert.AreSame(mainFormController.CoinPurse, returnChangeButtonController.CoinPurse);
            Assert.AreSame(mainFormController.CoinReturn, returnChangeButtonController.CoinReturn);
        }

        [Test]
        public void TestCorrectlyBuildsInsertCoinButtonPanelController()
        {
            MainFormController mainFormController = new MainFormController(new Form());

            InsertCoinButtonPanelController insertCoinButtonPanelController = mainFormController.InsertCoinButtonPanelController;

            Assert.IsInstanceOf(typeof(InsertCoinButtonPanelController), insertCoinButtonPanelController);
            Assert.AreSame(mainFormController.CoinAccepter,insertCoinButtonPanelController.CoinAccepter);
            Assert.AreSame(mainFormController.InsertCoinButtonPanel,insertCoinButtonPanelController.InsertCoinButtonPanel);
        }

        [Test]
        public void TestCorrectlyBuildsCoinReturnDisplayController()
        {
            Form mainForm = new Form();
            TextBox expectedTextBox = new TextBox() {Name = "CoinReturnDisplayTextBox"};
            mainForm.Controls.Add(expectedTextBox);

            MainFormController mainFormController = new MainFormController(mainForm);

            CoinReturnDisplayController coinReturnDisplayController = mainFormController.CoinReturnDisplayController;

            Assert.IsInstanceOf(typeof(CoinReturnDisplayController), coinReturnDisplayController);
            Assert.AreEqual(expectedTextBox, coinReturnDisplayController.Display);
            Assert.AreEqual(mainFormController.CoinReturn, coinReturnDisplayController.CoinReturn);
        }

        [Test]
        public void TestCorrectlyBuildsClearCoinReturnButtonController()
        {
            Form mainForm = new Form();
            Button expectedClearCoinReturnButton = new Button() {Name = "ClearCoinReturnButton"};
            mainForm.Controls.Add(expectedClearCoinReturnButton);

            MainFormController mainFormController = new MainFormController(mainForm);

            ClearCoinReturnButtonController clearCoinReturnButtonController = mainFormController.ClearCoinReturnButtonController;

            Assert.IsInstanceOf(typeof(ClearCoinReturnButtonController), clearCoinReturnButtonController);
            Assert.AreEqual(expectedClearCoinReturnButton, clearCoinReturnButtonController.Button);
            Assert.AreEqual(mainFormController.CoinReturn, clearCoinReturnButtonController.CoinReturn);
        }
    }
}
