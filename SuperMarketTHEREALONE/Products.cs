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

        public Products(int ID,string Name,string Summary,double Price,int Quantity, byte[] Image)
        {
            this.ProductID = ID;
            this.ProductName = Name;
            this.ProductSummary = Summary;  
            this.ProductPrice = Price;
            this.ProductQuantity = Quantity;
            this.ProductImage = Image;
        }
    }
}
