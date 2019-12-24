using DataCalculation.Analizis;
using DataCalculation.Model;
using DataCalculation.ValidationInput;

namespace HomeFinancialAssistant.InputAndOutPut
{
    public class OutputData : IOutputData<string>
    {
        public IAnalizisOfData<string> AnalizisOfData { get; set ; }
        public OutputData(IUserData userData, IValidation<double> validation)
        {
            AnalizisOfData = new DataAnalizis(userData,validation);
        }
        public void WriteConsoleError(string err)
        {
            System.Console.WriteLine(err);
        }

        public void WriteConsolePage(string page)
        {
            System.Console.WriteLine(page);
        }

        public void WriteConsoleReport(string report)
        {
            System.Console.WriteLine(report);
        }
    }
}
