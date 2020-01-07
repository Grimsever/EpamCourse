using FirstCode.Control;
using FirstCode.UI;
using Ninject;

namespace BusinessCalculator
{
    class Program
    {
        public static IKernel AppKernel;
        static void Main(string[] args)
        {
            AppKernel = new StandardKernel(new ControlVersion());
            var consoleUI = AppKernel.Get<UI>();
        }
    }
}
