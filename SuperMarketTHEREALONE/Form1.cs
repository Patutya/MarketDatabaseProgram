using System;
using System.Windows.Forms;

namespace SuperMarketTHEREALONE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (upName.Text == "" || upSurname.Text == "" || upEmail.Text == "" || upPassword.Text == "" || upAge.Text == "" || upAddress.Text == "" || upPhone.Text == "")
            {
                MessageBox.Show("Fill all txtboxes");
            }
            else 
            {
                SQLProcedures.InsertUsers(upName.Text, upSurname.Text, upEmail.Text, upPassword.Text, Convert.ToInt32(upAge.Text), upAddress.Text, Convert.ToInt32(upPhone.Text));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            upPassword.PasswordChar = '*';
            inPassword.PasswordChar = '*';
        }
    }
}
