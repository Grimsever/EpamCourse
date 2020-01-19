using Calculator.Model;

namespace Calculator.Realize.CalcChar
{
    public class CalculatorChar : ICalculator
    {
        public ICommands Commands { get; set; }

        public object Numb1 { get; private set; }

        public object Numb2 { get; private set; }

        public CalculatorChar(ICommands commands)
        {
            Commands = commands;
        }
        public bool CanUseThatCalc(string num1, string num2)
        {
            if (char.TryParse(num1, out char _num1) && char.TryParse(num2, out char _num2))
            {
                Numb1 = _num1;
                Numb2 = _num2;
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
