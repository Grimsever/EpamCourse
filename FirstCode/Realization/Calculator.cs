using DataAnaliz.Calculator;

namespace FirstCode.Realization
{
    public class Calculator : ICalculator<decimal>
    {
        public decimal Addition(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public decimal Division(decimal num1, decimal num2)
        {
            return num1 / num2;
        }
        public decimal Multiplication(decimal num1, decimal num2)
        {
            return num1 * num2;
        }

        public decimal Subtraction(decimal num1, decimal num2)
        {
            return num1 - num2;
        }
    }
}
