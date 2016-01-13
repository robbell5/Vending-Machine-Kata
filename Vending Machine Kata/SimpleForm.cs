using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vending_Machine_Kata.UserControls;

namespace Vending_Machine_Kata
{
    public partial class SimpleForm : Form
    {
        public SimpleForm()
        {
            InitializeComponent();

            new MainFormController(this);
        }
    }
}
