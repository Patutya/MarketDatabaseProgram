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
    public partial class Shop : Form
    {
        public string cart = "";
        public double full = 0;   

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
            Cart Cart = new Cart( cart,full);
            Cart.Show();
        }
    }
}





/*            MAIL SENDER
             using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress("sabaliluashvili@mziuri.ge");
                mail.To.Add(textBox1.Text);
                mail.Subject = "U just signed up for a 5k$ profit";
                mail.Body = cart;
                mail.IsBodyHtml = true;
                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new System.Net.NetworkCredential("sabaliluashvili@mziuri.ge", "MZIURI2015");
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                    textBox1.Text = "SENT";
                }
            }
 
 
 */