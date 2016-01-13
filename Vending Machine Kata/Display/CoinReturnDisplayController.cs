using System.Windows.Forms;
using Vending_Machine_Kata.MonetaryMechanism;

namespace Vending_Machine_Kata.Display
{
    public class CoinReturnDisplayController : IDisplayController, ICoinReturnObserver
    {
        public TextBox Display { get; }
        public ICoinReturn CoinReturn { get; set; }

        public CoinReturnDisplayController(ICoinReturn coinReturn)
        {
            CoinReturn = coinReturn;
            CoinReturn.RegisterObserver(this);
        }

        public void CoinReturnUpdated()
        {
        }
    }
}