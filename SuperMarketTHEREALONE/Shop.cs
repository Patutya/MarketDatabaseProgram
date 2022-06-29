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
        int pager = 0,pageCounter = 1;
        public string cart = "";
        public double full = 0;
        public User user = new User();
        List<Products> products = new List<Products>();

        string first = "";
        string second = "";
        string third = "";

        //---------------------------------------------------------------

        public Shop()
        {
            InitializeComponent();
        }
        public Shop(User user)
        {
            this.user = user;
            InitializeComponent();
        }
        private void Add1_Click(object sender, EventArgs e)
        {
            cart = cart + first;
        }
        private void Add2_Click(object sender, EventArgs e)
        {
            cart = cart + second;
        }
        private void Add3_Click(object sender, EventArgs e)
        {
            cart = cart + third;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            pager = products.Count;
            pager--;
        }
        private void Shop_Load(object sender, EventArgs e)
        {
            LoadProducts();
            PageLoader();
        }
        private void previous_Click(object sender, EventArgs e)
        {
            
            if (pager == 5)
            {
                pageCounter = products.Count / 3;
                pager = 2;
                PageLoader();
            }
            else
            {
                pager = pager + 3;
                PageLoader();
                pageCounter--;
            }
            lblPageCount.Text = Convert.ToString(pageCounter);
        }
        private void next_Click(object sender, EventArgs e)
        {
            if (pager == 2)
            {
                pager = products.Count;
                pager--;
                PageLoader();
                pageCounter = 1;
            }
            else
            {
                pageCounter++;
                pager = pager - 3;
                PageLoader();
            }
            lblPageCount.Text = Convert.ToString(pageCounter);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cart art = new Cart(cart,full);
            art.Show(); 
        }

        private void PageLoader()
        {
            
            Bitmap image1;
            groupBox3.Text = products[pager].ProductName;
            Price3.Text = Convert.ToString(products[pager].ProductPrice) + "$$";
            description3.Text = products[pager].ProductSummary;
            quantity3.Text = Convert.ToString(products[pager].ProductQuantity);
            using (MemoryStream stream = new MemoryStream(products[pager].ProductImage))
            {
                image1 = new Bitmap(stream);
            }
            pictureBox3.Image = image1;
            third = products[pager].ProductName + "  " + products[pager].ProductPrice + "$$  " + products[pager].ProductSummary + "\n";

            Bitmap image2;
            groupBox2.Text = products[pager-1].ProductName;
            Price2.Text = Convert.ToString(products[pager - 1].ProductPrice) + "$$";
            description2.Text = products[pager - 1].ProductSummary;
            quantity2.Text = Convert.ToString(products[pager - 1].ProductQuantity);
            using (MemoryStream stream = new MemoryStream(products[pager - 1].ProductImage))
            {
                image2 = new Bitmap(stream);
            }
            pictureBox2.Image = image2;
            second = products[pager - 1].ProductName + "  " + products[pager - 1].ProductPrice + "$$  " + products[pager - 1].ProductSummary + "\n";




            Bitmap image3;
            groupBox1.Text = products[pager-2].ProductName;
            Price1.Text = Convert.ToString(products[pager - 2].ProductPrice) + "$$";
            description1.Text = products[pager - 2].ProductSummary;
            quantity1.Text = Convert.ToString(products[pager - 2].ProductQuantity);
            using (MemoryStream stream = new MemoryStream(products[pager - 2].ProductImage))
            {
                image3 = new Bitmap(stream);
            }
            pictureBox1.Image = image3;
            first = products[pager - 2].ProductName + "  " + products[pager - 2].ProductPrice + "$$  " + products[pager - 2].ProductSummary + "\n";

        }
        // DONE  /|\
        //        |    |
        // INPRGR CODE V



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