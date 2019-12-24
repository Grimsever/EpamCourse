namespace HomeFinancialAssistant.InputAndOutPut
{
    public interface IInputData
    {
        void InputIncomeAndSource(double income, string source);
        void InputOutlayAndSource(double outlay, string source);
        void InputUserName(string name);
        void InputBudget(double budget);

    }
}
