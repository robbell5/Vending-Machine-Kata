using System.Collections.Generic;
using System.Windows.Forms;
using NUnit.Framework;
using Vending_Machine_Kata.MonetaryMechanism.Coin;
using Vending_Machine_Kata.MonetaryMechanism.UserControls;
using Vending_Machine_Kata_Tests.MonetaryMechanism.Coin;

namespace Vending_Machine_Kata_Tests.MonetaryMechanism.UserControls
{
    [TestFixture]
    public class ChangeReturnButtonControllerTest
    {
        [Test]
        public void TestProperties()
        {
            Button expectedChangeReturnButton = new Button();
            MockCoinPurse expectedCoinPurse = new MockCoinPurse();
            MockCoinReturn expectedCoinReturn = new MockCoinReturn();

            ChangeReturnButtonController changeReturnButtonController =
                new ChangeReturnButtonController(expectedChangeReturnButton, expectedCoinPurse, expectedCoinReturn);

            Assert.AreEqual(expectedChangeReturnButton, changeReturnButtonController.Button);
            Assert.AreEqual(expectedCoinPurse, changeReturnButtonController.CoinPurse);
            Assert.AreEqual(expectedCoinReturn, changeReturnButtonController.CoinReturn);
        }

        [Test]
        public void TestClickingTheButtonCallsClearOnCoinPurse()
        {
            Button changeReturnButton = new Button();
            MockCoinPurse mockCoinPurse = new MockCoinPurse();

            new ChangeReturnButtonController(changeReturnButton,
                mockCoinPurse, new MockCoinReturn());

            changeReturnButton.PerformClick();

            Assert.AreEqual(1, mockCoinPurse.NumberOfTimesClearWasCalled);
        }

        [Test]
        public void TestClickingTheButtonPassesTheCoinsReturnedFromClearToTheCoinReturn()
        {
            Button changeReturnButton = new Button();
            MockCoinPurse mockCoinPurse = new MockCoinPurse();
            MockCoinReturn mockCoinReturn = new MockCoinReturn();

            List<ICoin> coinsFromCoinPurse = new List<ICoin>() {new MockCoin(), new MockCoin()};
            mockCoinPurse.CoinsToReturnFromClear = coinsFromCoinPurse;

            new ChangeReturnButtonController(changeReturnButton,
                mockCoinPurse, mockCoinReturn);

            changeReturnButton.PerformClick();

            List<ICoin> coinsPassedToCoinReturn = mockCoinReturn.CoinsPassedToAddCoin;

            Assert.AreEqual(coinsFromCoinPurse.Count, coinsPassedToCoinReturn.Count);

            foreach (ICoin coinFromCoinPurse in coinsFromCoinPurse)
                Assert.Contains(coinFromCoinPurse, coinsPassedToCoinReturn);
        }
    }
}
