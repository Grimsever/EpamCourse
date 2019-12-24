using System.Collections.Generic;

namespace DataCalculation.Model
{
    public interface IUserData
    {
        string UserName { get; set; }
        double InitailBudget { get; set; }
        List<IData> Datas { get; set; }

        IData CreateNewNote(double income, double outlay, string source);

        void AddNewNote(double income, double outlay, string source);
    }
}
