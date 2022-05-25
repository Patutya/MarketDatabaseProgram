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
    public partial class Cart : Form
    {
        string cart = "";
        double full = 0;
        public string Cart
        {
            get { return Cart; }   
            set { Cart = shop.cart; }  
        }



        public Cart()
        {
            InitializeComponent();
        }

        private void Cart_Load(object sender, EventArgs e) // <amas vgulisxmob
        {
            
        }
    }
}
