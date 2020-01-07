namespace DataUserModel.Users.DataAccessLayer
{
    public interface IWorker
    {
        string Name { get; set; }
        string Profession { get; set; }
        decimal Salary { get; set; }
    }
}
