namespace DataUserModel.Users.DataAccessLayer
{
    public interface IData
    {
        decimal RentalPrice { get; set; }
        IWorker[] Workers { get; set; }
        IProduct Products { get; set; }
    }
}
