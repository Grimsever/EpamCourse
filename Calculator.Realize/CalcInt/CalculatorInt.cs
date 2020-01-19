using Calculator.Model;

namespace Calculator.Realize.CalcInt
{
    public class CalculatorInt : ICalculator
    {
        public ICommands Commands { get; private set; }
        public object Numb1 { get; private set; }
        public object Numb2 { get; private set; }

        public CalculatorInt(ICommands commands)
        {
            Commands = commands;
        }
        public bool CanUseThatCalc(string num1, string num2)
        {
            if (int.TryParse(num1, out int numb1) && int.TryParse(num2, out int numb2))
            {
                Numb1 = numb1;
                Numb2 = numb2;
                return true;
            }
            else
            {
                return false;
            }
        }
        public object Addition()
        {
            return Commands.Addition(Numb1, Numb2);
        }

        public object Subtraction()
        {
            return Commands.Subtraction(Numb1, Numb2);
        }

        public object Multiplication()
        {
            return Commands.Multiplication(Numb1, Numb2);
        }

        public object Division()
        {
            return Commands.Division(Numb1, Numb2);
        }
    }
}
