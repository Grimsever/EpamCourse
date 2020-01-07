
using DataUserModel.Users.DataAccessLayer;

namespace DataUserModel.Users
{
    public class User
    {
        public string Name { get; set; }
        public string Password { get; set; }

        public IData data;
        public User(IData data)
        {
            this.data = data;
        }
    }
}
