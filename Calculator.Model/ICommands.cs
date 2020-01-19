namespace Calculator.Model
{
    public interface ICommands
    {
        object Addition(object num1, object num2);

        object Subtraction(object num1, object num2);

        object Multiplication(object num1, object num2);

        object Division(object num1, object num2);
    }
}
