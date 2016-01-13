using System.Windows.Forms;
using NUnit.Framework;
using Vending_Machine_Kata.Display;
using Vending_Machine_Kata.MonetaryMechanism;
using Vending_Machine_Kata.MonetaryMechanism.Coin;
using Vending_Machine_Kata.UserControls;

namespace Vending_Machine_Kata_Tests.UserControls
{
    [TestFixture]
    public class MainFormWrapperTest
    {
        [Test]
        public void TestBaseProperties()
        {
            Form expectedForm = new Form();
            MainFormWrapper mainFormWrapper = new MainFormWrapper(expectedForm);

            Assert.AreSame(expectedForm, mainFormWrapper.MainForm);
        }

        [Test]
        public void TestBuildsInsertCoinButtonPanel()
        {
            Form mainForm = new Form();
            MainFormWrapper mainFormWrapper = new MainFormWrapper(mainForm);

            Assert.IsInstanceOf(typeof(IInsertCoinButtonPanel), mainFormWrapper.InsertCoinButtonPanel);
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

            MainFormWrapper mainFormWrapper = new MainFormWrapper(mainForm);

            IInsertCoinButtonPanel insertCoinButtonPanel = mainFormWrapper.InsertCoinButtonPanel;

            Assert.AreSame(expectedInsertPennyButton, insertCoinButtonPanel.InsertPennyButton);
            Assert.AreSame(expectedInsertNickelButton, insertCoinButtonPanel.InsertNickelButton);
            Assert.AreSame(expectedInsertDimeButton, insertCoinButtonPanel.InsertDimeButton);
            Assert.AreSame(expectedInsertQuaterButton, insertCoinButtonPanel.InsertQuarterButton);
        }

        [Test]
        public void TestCorrectlyBuildsCoinPurse()
        {
            MainFormWrapper mainFormWrapper = new MainFormWrapper(new Form());

            ICoinPurse coinPurse = mainFormWrapper.CoinPurse;

            Assert.IsInstanceOf(typeof(ICoinPurse), coinPurse);
        }

        [Test]
        public void TestCorrectlyBuildsCoinReturn()
        {
            MainFormWrapper mainFormWrapper = new MainFormWrapper(new Form());

            ICoinReturn coinPurse = mainFormWrapper.CoinReturn;

            Assert.IsInstanceOf(typeof(ICoinReturn), coinPurse);
        }

        [Test]
        public void TestCorrectlyBuildsCoinFactory()
        {
            MainFormWrapper mainFormWrapper = new MainFormWrapper(new Form());

            ICoinFactory coinFactory = mainFormWrapper.CoinFactory;

            Assert.IsInstanceOf(typeof(ICoinFactory), coinFactory);
        }

        [Test]
        public void TestCorrectlyBuildsCoinAccepter()
        {
            MainFormWrapper mainFormWrapper = new MainFormWrapper(new Form());

            ICoinAccepter coinAccepter = mainFormWrapper.CoinAccepter;

            Assert.IsInstanceOf(typeof(ICoinAccepter), coinAccepter);
            Assert.AreSame(mainFormWrapper.CoinFactory, coinAccepter.CoinFactory);
            Assert.AreSame(mainFormWrapper.CoinPurse, coinAccepter.CoinPurse);
            Assert.AreSame(mainFormWrapper.CoinReturn, coinAccepter.CoinReturn);
        }

        [Test]
        public void TestCorrectlyBuildsDisplayController()
        {
            Form mainForm = new Form();
            TextBox expectedDisplayTextBox = new TextBox();
            expectedDisplayTextBox.Name = "DisplayTextBox";
            mainForm.Controls.Add(expectedDisplayTextBox);

            MainFormWrapper mainFormWrapper = new MainFormWrapper(mainForm);

            DisplayController displayController = mainFormWrapper.DisplayController;

            Assert.IsInstanceOf(typeof(DisplayController), displayController);
            Assert.AreSame(expectedDisplayTextBox, displayController.Display);
            Assert.AreSame(mainFormWrapper.CoinPurse, displayController.CoinPurse);
        }
    }
}
