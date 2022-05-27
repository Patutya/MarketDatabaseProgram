using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SuperMarketTHEREALONE
{
    public partial class Form1 : Form
    {
        string admin = "diaxmas@gisment.mz";
        string pass = "michedavs";


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
                MessageBox.Show("Now you can log in!");
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
            if(admin == inEmail.Text && pass == inPassword.Text)
            {
                Admin admin = new Admin ();
                admin.Show();
                this.Hide();
            }
            else if ("SQL" == inEmail.Text && "TEST" == inPassword.Text)
            {
                Shop shop = new Shop();
                shop.Show();
                this.Hide();
            }
            else
            {
                bool isLoggedIn = false;
                LoadUsers();
                foreach (User user in Users)
                {
                    if (user.Email == inEmail.Text && user.Password == inPassword.Text)
                    {
                        isLoggedIn = true;
                    }

                }
                if (!isLoggedIn)
                {
                    MessageBox.Show("vershexvedit ");
                }
                else
                {
                    Shop shop = new Shop();
                    shop.Show();
                    this.Hide();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
    }
}
/*
 
 string admin = "giosaba@mail"


if(intxt == admin)
{




}

 
 
 
 
 
 
 
 
 
 
 
 */