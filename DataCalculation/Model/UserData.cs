using DataCalculation.ValidationInput;
using Ninject;
using System.Collections.Generic;

namespace DataCalculation.Model
{
    public class UserData : IUserData
    {
        public string UserName { get; set; }
        public List<IData> Datas { get; set; }
        public double InitailBudget { get; set; }

        [Inject]
        private IValidation<double> validation;

        public UserData(IValidation<double> valid)
        {
            validation = valid;
            Datas = new List<IData>();
        }

        public IData CreateNewNote(double income, double outlay, string source)
        {
            if (validation.ValidationForAnalizis(this))
            {
                return new Data(Datas[Datas.Count - 1].ActualBudget, income, outlay, source);
            }
            else
            {
                return new Data(InitailBudget, income, outlay, source);
            }
        }

        public void AddNewNote(double income, double outlay, string source)
        {
            Datas.Add(CreateNewNote(income, outlay, source));
        }
    }
}
