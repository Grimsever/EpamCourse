namespace Calculator.Model
{
    public interface ICommandList
    {
        ICalculator GetCalc(string num1, string num2);
    }
}
