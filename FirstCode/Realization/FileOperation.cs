using DataUserModel.OperationWithFile;
using DataUserModel.Users;
using Newtonsoft.Json;
using System.IO;

namespace FirstCode.Realization
{
    public class FileOperation : IFileOperation
    {
        private JsonSerializerSettings settings;
        public FileOperation()
        {
            settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
        }
        public bool IsCheckFile(string name, string pass)
        {
            string nameFile = name + pass + ".json";
            return File.Exists(nameFile);
        }

        public User ReadFile(string name, string pass)
        {
            string nameFile = (name + pass) + ".json";
            return JsonConvert.DeserializeObject<User>(File.ReadAllText(nameFile), settings);
        }

        public bool WriteFile(User user)
        {
            string nameFile = (user.Name + user.Password) + ".json";
            string serialized = JsonConvert.SerializeObject(user, settings);
            if (!File.Exists(nameFile))
            {
                File.Create(nameFile).Close();
            }
            File.WriteAllText(nameFile, serialized);
            return true;
        }

        public bool DeleteFile(User user)
        {
            string nameFile = (user.Name + user.Password) + ".json";
            File.Delete(nameFile);
            return true;
        }

    }

}
