using DataCalculation.Analizis;
using DataCalculation.Model;
using DataCalculation.ValidationInput;

namespace HomeUI.View
{
    internal class OutputData : IOutputData<string>
    {
        public IAnalizisOfData<string> AnalizisOfData { get; set ; }
        public OutputData(IAnalizisOfData<string> analiz)
        {
            AnalizisOfData = analiz;
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
