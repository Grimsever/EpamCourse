using DataCalculation.Model;
using HomeUI;
using HomeUI.View;
using Ninject;

namespace HomeFinancialAssistant
{
    class Program
    {
        public static IKernel AppKernel;
        static void Main(string[] args)
        {
            AppKernel = new StandardKernel(new ControlVer());
            var consoleUI = AppKernel.Get<UI>();
            consoleUI.GetMainPage();

        }
    }
}
