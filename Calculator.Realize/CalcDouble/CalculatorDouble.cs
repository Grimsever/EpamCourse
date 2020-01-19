using Calculator.Model;

namespace Calculator.Realize.CalcDouble
{
    public class CalculatorDouble : ICalculator
    {
        public ICommands Commands { get; set; }
        public object Numb1 { get; private set; }
        public object Numb2 { get; private set; }

        public CalculatorDouble(ICommands commands)
        {
            Commands = commands;
        }
        public bool CanUseThatCalc(string num1, string num2)
        {
            if (double.TryParse(num1, out double numb1) && double.TryParse(num2, out double numb2))
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
