using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SuperMarketTHEREALONE
{
    public partial class Form1 : Form
    {
        List<User> Users = new List<User>();
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
                upName.Clear();
                upSurname.Clear();
                upEmail.Clear();
                upPassword.Clear();
                upAge.Clear();
                upAddress.Clear();
                upPhone.Clear();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            upPassword.PasswordChar = '*';
            inPassword.PasswordChar = '*';
        }
        private void LoadUsers()
        {
            DataTable teibl = SQLProcedures.SelectUsers();
            for (int i = 0; i < teibl.Rows.Count; i++)
            {
                var row = teibl.Rows[i];
                User user = new User();
                user.ID = Convert.ToInt32(row["UserID"]);
                user.Name = Convert.ToString(row["UserName"]);
                user.Surname = Convert.ToString(row["UserSurname"]);
                user.Email = Convert.ToString(row["UserEmail"]);
                user.Password = Convert.ToString(row["UserPassword"]);
                user.Age = Convert.ToInt32(row["UserAge"]);
                user.Address = Convert.ToString(row["UserAddress"]);
                user.PhoneNumber = Convert.ToInt32(row["UserPhoneNumber"]);
                Users.Add(user);
            }
        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            bool isLoggedIn = false;
            LoadUsers();
            foreach (User user in Users)
            {
                if(user.Email == inEmail.Text && user.Password == inPassword.Text)
                {
                    //naklebia dasaweri
                    isLoggedIn = true;
                    Shop shop = new Shop();
                    shop.Show();
                    this.Hide();
                }
                
            }
            if (!isLoggedIn)
            {
                MessageBox.Show("vershexvedit ");
            }
        }
    }
}
