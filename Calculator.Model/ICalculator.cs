namespace Calculator.Model
{
    public interface ICalculator
    {
        object Numb1 { get; }
        object Numb2 { get; }
        ICommands Commands { get; }

        bool CanUseThatCalc(string num1, string num2);
        object Addition();
        object Subtraction();
        object Multiplication();

        object Division();

    }

}
