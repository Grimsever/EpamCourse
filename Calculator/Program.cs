using Calculator.CalculatorConsole;
using Calculator.Realize.NinjecInitial;
using Ninject;

namespace Calculator
{
    class Program
    {
        public static IKernel AppKernel;
        static void Main(string[] args)
        {
            AppKernel = new StandardKernel(new ControlVersion());
            var consoleUI = AppKernel.Get<UiConsole>();
            consoleUI.Start();
        }
    }
}
