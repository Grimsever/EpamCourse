using DataUserModel.OperationWithFile;

namespace DataUserModel.Users.DataAccessLayer
{
    public interface IUserData
    {
        IFileOperation FileOperation { get; set; }
        User GetUser(string name, string pass);

        bool AddUser(User user);

        User EditUSer(User user);

        bool DeleteUser(User user);
    }
}
