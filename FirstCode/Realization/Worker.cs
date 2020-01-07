using DataUserModel.Users.DataAccessLayer;

namespace FirstCode.Realization
{
    public class Worker : IWorker
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public decimal Salary { get; set; }
        public Worker(string name, string profession, decimal salary)
        {
            Name = name;
            Salary = salary;
            Profession = profession;
        }
    }
}
