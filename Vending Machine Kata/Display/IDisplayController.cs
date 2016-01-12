using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vending_Machine_Kata.Display
{
    public interface IDisplayController
    {
        TextBox Display { get; }
    }
}
