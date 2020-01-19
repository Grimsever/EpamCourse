using Calculator.Model;
using System;

namespace Calculator.Realize.CalcChar
{
    public class CommandChar : ICommands
    {
        public object Addition(object num1, object num2)
        {
            return  Convert.ToChar((char)num1 + (char)num2);
        }

        public object Division(object num1, object num2)
        {
            return Convert.ToChar((char)num1 / (char)num2);
        }

        public object Multiplication(object num1, object num2)
        {
            return Convert.ToChar((char)num1 * (char)num2);
        }

        public object Subtraction(object num1, object num2)
        {
            return Convert.ToChar((char)num1 - (char)num2);
        }
    }
}
