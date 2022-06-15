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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'superMarket.Cart' table. You can move, or remove it, as needed.
            this.cartTableAdapter.Fill(this.superMarket.Cart);
            // TODO: This line of code loads data into the 'superMarket.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.superMarket.Users);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Application.Restart(); //tadaaaaa
        }

        private void productsBTN_Click(object sender, EventArgs e)
        {
            AdminProducts pro = new AdminProducts();
            pro.Show();
            this.Hide();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.superMarket);

        }
    }
}
