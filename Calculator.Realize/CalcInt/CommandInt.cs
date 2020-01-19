using Calculator.Model;

namespace Calculator.Realize.CalcInt
{
    public class CommandInt : ICommands
    {
        public object Addition(object num1, object num2)
        {
            return (int)num1 + (int)num2;
        }

        public object Division(object num1, object num2)
        {
            return (int)num1 / (int)num2;
        }

        public object Multiplication(object num1, object num2)
        {
            return (int)num1 * (int)num2;
        }

        public object Subtraction(object num1, object num2)
        {
            return (int)num1 - (int)num2;
        }
    }
}
