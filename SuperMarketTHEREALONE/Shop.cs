using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SuperMarketTHEREALONE
{

    public partial class Shop : Form
    {

        public string cart = "";
        public double full = 0;
        public User user = new User();
        List<Products> products = new List<Products>();
        int Num = 0;
        Products first = new Products();
        Products second = new Products();
        Products third = new Products();
        //--------------------------------------------

        public Shop() { InitializeComponent(); }
        public Shop(User user)
        {
            this.user = user;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void PageLoader()
        {
            Num = products.Count;
            Num -= 3;

            Bitmap image1;
            groupBox3.Text = products[2].ProductName;
            Price3.Text = Convert.ToString(products[2].ProductPrice)+ "$$";
            description3.Text = products[2].ProductSummary;
            quantity3.Text = Convert.ToString(products[2].ProductQuantity);
            using (MemoryStream stream = new MemoryStream(products[2].ProductImage))
            {
                image1 = new Bitmap(stream);
            }
            pictureBox3.Image = image1;



            Bitmap image2;
            groupBox2.Text = products[1].ProductName;
            Price2.Text = Convert.ToString(products[1].ProductPrice) + "$$";
            description2.Text = products[1].ProductSummary;
            quantity2.Text = Convert.ToString(products[1].ProductQuantity);
            using (MemoryStream stream = new MemoryStream(products[1].ProductImage))
            {
                image2 = new Bitmap(stream);
            }
            pictureBox2.Image = image2;



            Bitmap image3;
            groupBox1.Text = products[0].ProductName;
            Price1.Text = Convert.ToString(products[0].ProductPrice) + "$$";
            description1.Text = products[0].ProductSummary;
            quantity1.Text = Convert.ToString(products[0].ProductQuantity);
            using (MemoryStream stream = new MemoryStream(products[0].ProductImage))
            {
                image3 = new Bitmap(stream);
            }
            pictureBox1.Image = image3;
        }
        private void LoadProducts()
        {

            DataTable teibl = SQLProcedures.SelectProducts();
            for (int i = 0; i < teibl.Rows.Count; i++)
            {
                var row = teibl.Rows[i];
                Products product = new Products();
                bool canAdd = true;
                product.ProductID = Convert.ToInt32(row["ProductID"]);
                product.ProductName = Convert.ToString(row["ProductName"]);
                product.ProductSummary = Convert.ToString(row["ProductSummary"]);
                product.ProductPrice = Convert.ToDouble(row["ProductPrice"]);
                product.ProductQuantity = Convert.ToInt32(row["ProductQuantity"]);
                product.ProductImage = (byte[])row["ProductImage"];
                foreach (Products crproduct in products)
                {
                    if (crproduct.ProductID == product.ProductID)
                    {
                        canAdd = false;
                        break;
                    }
                }
                if (canAdd)
                {
                    products.Add(product);
                }
            }
        }
        // DONE  /|\
        //        |    |
        // INPRGR CODE V

        private void Shop_Load(object sender, EventArgs e)
        {
            LoadProducts();
            PageLoader();

        }
        private void Add1_Click(object sender, EventArgs e)
        {

        }
        private void Add2_Click(object sender, EventArgs e)
        {

        }
        private void Add3_Click(object sender, EventArgs e)
        {

        }
        private void previous_Click(object sender, EventArgs e)
        {

        }

        private void next_Click(object sender, EventArgs e)
        {

        }
    }
}
/*
Bitmap image;
using (MemoryStream stream = new MemoryStream(imgString))
{
    image = new Bitmap(stream);
}
pictureBox1.Image = image;
*/