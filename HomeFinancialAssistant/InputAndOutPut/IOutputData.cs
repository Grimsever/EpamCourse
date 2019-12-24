using DataCalculation.Analizis;

namespace HomeFinancialAssistant.InputAndOutPut
{
    public interface IOutputData<T>
    {
        IAnalizisOfData<string> AnalizisOfData { get; set; }
        void WriteConsoleReport(T report);
        void WriteConsoleError(T err);
        void WriteConsolePage(T page);
    }
}
