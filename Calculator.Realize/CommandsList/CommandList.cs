using Calculator.Model;
using Calculator.Realize.CalcDouble;
using Calculator.Realize.CalcInt;
using Calculator.Realize.CalcChar;
using Calculator.Realize.CalcString;

namespace Calculator.Realize.CommandsList
{
    public class CommandList : ICommandList
    {
        private ICalculator[] calculators;
        private ICommands[] commands;
        public CommandList()
        {
            commands = new ICommands[]
            {
                new CommandInt(),
                new CommandDouble(),
                new CommandChar(),
                new CommandString()
            };
            calculators = new ICalculator[]
            {
                new CalculatorInt(commands[0]),
                new CalculatorDouble(commands[1]),
                new CalculatorChar(commands[2]),
                new CalculatorString(commands[3])
            };
        }

        public ICalculator GetCalc(string num1, string num2)
        {
            foreach (var com in calculators)
            {
                if (com.CanUseThatCalc(num1, num2))
                {
                    return com;
                }
            }
            return null;
        }
    }
}
