namespace SuperMarketTHEREALONE
{
    internal class Products
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductSummary { get; set; }
        public double ProductPrice { get; set; }
        public int ProductQuantity { get; set; }
        public byte[] ProductImage { get; set; }

        public Products(int ProductID, string ProductName, string ProductSummary, double ProductPrice, int ProductQuantity, byte[] ProductImage)
        {
            this.ProductID = ProductID;
            this.ProductName = ProductName;
            this.ProductSummary = ProductSummary;  
            this.ProductPrice = ProductPrice;
            this.ProductQuantity = ProductQuantity;
            this.ProductImage = ProductImage;
        }
        public Products() { }
    }
}
