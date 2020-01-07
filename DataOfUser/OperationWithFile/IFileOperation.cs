using DataUserModel.Users;

namespace DataUserModel.OperationWithFile
{
    public interface IFileOperation
    {
        bool IsCheckFile(string name, string pass);
        User ReadFile(string name, string pass);
        bool WriteFile(User user);
        bool DeleteFile(User user);
    }
}
