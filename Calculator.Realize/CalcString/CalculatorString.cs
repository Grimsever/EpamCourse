using Calculator.Model;

namespace Calculator.Realize.CalcString
{
    public class CalculatorString : ICalculator
    {
        public ICommands Commands { get; set; }

        public object Numb1 { get; private set; }

        public object Numb2 { get; private set; }
        public CalculatorString(ICommands commands)
        {
            Commands = commands;
        }
        public bool CanUseThatCalc(string num1, string num2)
        {
            Numb1 = num1;
            Numb2 = num2;
            return true;
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
