using System;

namespace Module3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            Console.WriteLine("Enter the second number");
            if (double.TryParse(Console.ReadLine(),out double firstNum) && double.TryParse(Console.ReadLine(),out double secondNum))
            {
                double result = 0;
                for (int i = 0; i < Math.Abs(firstNum); i++)
                {
                    result += secondNum;
                }
                if ((firstNum > 0 && secondNum > 0) || (firstNum < 0 && secondNum < 0))
                {
                    Console.WriteLine($"Result of multiply is {Math.Abs(result)}");
                }
                else if (firstNum < 0)
                    Console.WriteLine($"Result of multiply is {-result}");
                else
                    Console.WriteLine($"Result of multiply is {result}");
            }
            else
            {
                Console.WriteLine("You made a mistakes in inputting");
            }
        }
    }
}
