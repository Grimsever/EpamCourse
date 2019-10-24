using System;

namespace Module3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number(integer or fractional)");
            if (double.TryParse(Console.ReadLine(), out double number))
            {
                
                string input =number>0? number.ToString():Math.Abs(number).ToString();
                string output = "";
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    if (input[i] != 0)
                    {
                        output += input[i];
                    }
                }
                double outputNumber =number>0? double.Parse(output):-double.Parse(output);
                Console.WriteLine($"Result {outputNumber}");
            }
            else
            {
                Console.WriteLine("You made mistake in input");
            }
        }
    }
}
