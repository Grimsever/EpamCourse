using DataUserModel.Users.DataAccessLayer;

namespace FirstCode.Realization
{
    public class Product : IProduct
    {
        public string Name { get; set; }
        public double Count { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }

        public Product()
        {
        }
        public Product(string name, decimal purchasePrice, double count, double percent)
        {
            Name = name;
            PurchasePrice = purchasePrice;
            Count = count;
            SalePrice = purchasePrice * (1 + (decimal)percent / 100);
        }
    }
}
