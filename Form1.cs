using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VegaPowerPC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Vega v = new Vega("ab", 100, 200, 0, 0, 0.1, 0.2);
        }
    }
}
