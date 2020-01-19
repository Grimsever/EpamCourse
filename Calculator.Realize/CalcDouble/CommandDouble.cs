using Calculator.Model;

namespace Calculator.Realize.CalcDouble
{
    public class CommandDouble : ICommands
    {
        public object Addition(object num1, object num2)
        {
            return (double)num1 + (double)num2;
        }

        public object Division(object num1, object num2)
        {
            return (double)num1 / (double)num2;
        }

        public object Multiplication(object num1, object num2)
        {
            return (double)num1 * (double)num2;
        }

        public object Subtraction(object num1, object num2)
        {
            return (double)num1 - (double)num2;
        }

    }
}
