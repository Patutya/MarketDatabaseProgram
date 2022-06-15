using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Windows.Forms;

namespace SuperMarketTHEREALONE
{
    public partial class Forgor : Form
    {
        public static string connstr = "Data Source=DESKTOP-J23P8GB\\SQLEXPRESS;Initial Catalog=SuperMarket;Integrated Security=True";
        public static SqlConnection conn = new SqlConnection(connstr);
        public static SqlCommand cmd;
        public static SqlDataAdapter dataAdapter;
        bool mailCorrect = false;
        List<User> Users = new List<User>();
        int code = 0;
        public Forgor()
        {
            InitializeComponent();
        }
        private void LoadUsers()
        {
            DataTable teibl = SQLProcedures.SelectUsers();
            for (int i = 0; i < teibl.Rows.Count; i++)
            {
                var row = teibl.Rows[i];
                User user = new User();
                bool canAdd = true;
                user.ID = Convert.ToInt32(row["UserID"]);
                user.Name = Convert.ToString(row["UserName"]);
                user.Surname = Convert.ToString(row["UserSurname"]);
                user.Email = Convert.ToString(row["UserEmail"]);
                user.Password = Convert.ToString(row["UserPassword"]);
                user.Age = Convert.ToInt32(row["UserAge"]);
                user.Address = Convert.ToString(row["UserAddress"]);
                user.PhoneNumber = Convert.ToInt32(row["UserPhoneNumber"]);
                foreach (User currnetUser in Users)
                {
                    if (currnetUser.ID == user.ID)
                    {
                        canAdd = false;
                        break;
                    }
                }
                if (canAdd)
                {
                    Users.Add(user);
                }
            }
        }

        private void Forgor_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void CodeSender_Click(object sender, EventArgs e)
        {
            foreach (User user in Users)
            {
                if (user.Email == MailBox.Text)
                {
                    mailCorrect = true;
                    break;
                }
            }
            if (mailCorrect == false)
            {
                MessageBox.Show("sheiyvanet registrirebuli meili");
            }
            else
            {
                try
                {


                    using (MailMessage mail = new MailMessage())
                    {
                        Random ran = new Random();
                        mail.From = new MailAddress("diaxmasgisment@gmail.com");
                        mail.To.Add(MailBox.Text);
                        mail.Subject = "SuperMarket Password Reset";
                        code = ran.Next(1000, 9999);
                        mail.Body = "Code:" + code;
                        mail.IsBodyHtml = true;
                        using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                        {
                            smtp.Credentials = new System.Net.NetworkCredential("diaxmasgisment@gmail.com", "aahxiqrahabgdthl");
                            smtp.EnableSsl = true;
                            smtp.Send(mail);
                            CodeSender.Text = "SENT";
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("sheiyvanet swore meil");
                }
            }
        }

        private void PasswordRecovery_Click(object sender, EventArgs e)
        {
            if (CodeBox.Text == Convert.ToString(code))
            {
                cmd = new SqlCommand("PasswordRecovery", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter[] sp = new SqlParameter[2];
                sp[0] = new SqlParameter("@email", SqlDbType.NVarChar, (50));
                sp[0].Value = MailBox.Text;
                sp[1] = new SqlParameter("@password", SqlDbType.NVarChar, (50));
                sp[1].Value = PasswordBox.Text;
                cmd.Parameters.AddRange(sp);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("paroli sheicvala exa dalogindiot");
                Application.Restart();
            }
            else
            {
                MessageBox.Show("Mail Code Missing");
            }
        }
    }
}
