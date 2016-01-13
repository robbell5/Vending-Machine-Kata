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
    public class ChangeReturnDisplayControllerTest
    {
        [Test]
        public void TestImplementsInterface()
        {
            ChangeReturnDisplayController changeReturnDisplayController = new ChangeReturnDisplayController();
            Assert.IsInstanceOf(typeof(IDisplayController), changeReturnDisplayController);
            Assert.IsInstanceOf(typeof(IChangeReturnObserver), changeReturnDisplayController);
        }
    }
}
