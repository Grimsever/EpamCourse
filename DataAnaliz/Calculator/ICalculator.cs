namespace DataAnaliz.Calculator
{
    public interface ICalculator<T>
    {
        T Addition(T num1, T num2);

        T Subtraction(T num1, T num2);

        T Multiplication(T num1, T num2);

        T Division(T num1, T num2);
    }
}
