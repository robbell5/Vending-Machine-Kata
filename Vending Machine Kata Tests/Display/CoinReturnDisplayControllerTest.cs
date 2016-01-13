using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Vending_Machine_Kata.Display;
using Vending_Machine_Kata.MonetaryMechanism;

namespace Vending_Machine_Kata_Tests.Display
{
    [TestFixture]
    public class CoinReturnDisplayControllerTest
    {
        [Test]
        public void TestImplementsInterface()
        {
            CoinReturnDisplayController coinReturnDisplayController = new CoinReturnDisplayController();
            Assert.IsInstanceOf(typeof(IDisplayController), coinReturnDisplayController);
            Assert.IsInstanceOf(typeof(ICoinReturnObserver), coinReturnDisplayController);
        }
    }
}
