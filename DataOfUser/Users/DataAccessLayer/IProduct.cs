namespace DataUserModel.Users.DataAccessLayer
{
    public interface IProduct
    {
        string Name { get; set; }
        decimal PurchasePrice { get; set; }
        decimal SalePrice { get; set; }
        double Count { get; set; }

    }
}
