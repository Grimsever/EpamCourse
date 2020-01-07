using DataUserModel.OperationWithFile;
using DataUserModel.Users;
using DataUserModel.Users.DataAccessLayer;

namespace FirstCode.Realization
{
    public class UserData : IUserData
    {
        public IFileOperation FileOperation { get; set; }

        public UserData(IFileOperation fileOperation)
        {
            FileOperation = fileOperation;
        }
        public bool AddUser(User user)
        {
            return FileOperation.WriteFile(user);
        }

        public bool DeleteUser(User user)
        {
            return FileOperation.DeleteFile(user);
        }

        public User EditUSer(User user)
        {
            FileOperation.WriteFile(user);
            return user;
        }

        public User GetUser(string name, string pass)
        {
            if (FileOperation.IsCheckFile(name, pass))
            {
                return FileOperation.ReadFile(name, pass);
            }
            else
            {
                return null;
            }
        }
    }
}
