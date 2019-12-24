using DataCalculation.Model;

namespace HomeFinancialAssistant.InputAndOutPut
{
    public class InputData : IInputData
    {
        public IUserData DataUser { get; set; }
        public InputData(IUserData userData)
        {
            DataUser = userData;
        }

        public void InputIncomeAndSource(double income,string source)
        {
            DataUser.AddNewNote(income, 0,source);
        }

        public void InputOutlayAndSource(double outlay, string source)
        {
            DataUser.AddNewNote(0,outlay, source);
        }
        public void InputUserName(string name)
        {
            DataUser.UserName = name;
        }

        public void InputBudget(double budget)
        {
            DataUser.InitailBudget = budget;
        }

    }
}
