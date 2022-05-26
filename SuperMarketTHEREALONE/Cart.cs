using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarketTHEREALONE
{
    public partial class Cart : Form
    {
        string cart;
        double full;
        public Cart(string cart,double full)
        {
            InitializeComponent();
            this.cart = cart;
            this.full = full;
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress("sabaliluashvili@mziuri.ge");
                mail.To.Add(Emailtxt.Text);
                mail.Subject = Nametxt.Text+Surnametxt.Text +"Receipt for the purchase:";
                mail.Body = "Are you trying to buy the follow items: \n" + cart +"\n"+Convert.ToString(full)+"$$\n";
                mail.IsBodyHtml = true;
                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new System.Net.NetworkCredential("sabaliluashvili@mziuri.ge", "MZIURI2015");
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                    label1.Text = "SENT";
                }
            }
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            CartTxt.Text = cart;
            lblPrice.Text = Convert.ToString(full);
        }
    }
}
