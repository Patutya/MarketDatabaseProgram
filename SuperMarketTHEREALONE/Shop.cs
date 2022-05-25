using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarketTHEREALONE
{
    public partial class Shop : Form
    {
        string cart = "";
        double full = 0;   

        public Shop()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Add1_Click(object sender, EventArgs e)
        {
            cart += "\n VIRUS: TROJAN 199.99$ "; 
            full += 199.99;
        }

        private void Add2_Click(object sender, EventArgs e)
        {
            cart += "\n VIRUS: BONZI 37.99$"; 
            full += 37.99;
        }

        private void Add3_Click(object sender, EventArgs e)
        {
            cart += "\n VIRUS: I LOVE YOU 247.99$";
            full += 247.99;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.Show();
        }
    }
}
