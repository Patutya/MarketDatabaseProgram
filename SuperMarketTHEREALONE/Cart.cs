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
            try
            {


                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress("diaxmasgisment@gmail.com");
                    mail.To.Add(Emailtxt.Text);
                    mail.Subject = Nametxt.Text +" "+ Surnametxt.Text + " Receipt for the purchase:";
                    mail.Body = "Are you trying to buy the following items: \n" + cart + "\n" + Convert.ToString(full) + "$$\n";
                    mail.IsBodyHtml = true;
                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new System.Net.NetworkCredential("diaxmasgisment@gmail.com", "aahxiqrahabgdthl");
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                        label1.Text = "SENT";
                        label2.Text = "THANK YOU FOR THE PURCHASE <3";
                    }
                }
            }
            catch 
            {
                MessageBox.Show("sheiyvanet swore meil");
            }
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            CartTxt.Text = cart;
            lblPrice.Text = Convert.ToString(full);
        }
    }
}
