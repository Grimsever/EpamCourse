using System;

namespace Module2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first and second number ");
            if (double.TryParse(Console.ReadLine(), out double num_1) && double.TryParse(Console.ReadLine(),out double num_2))
            {
                num_1 = num_1 + num_2;
                num_2 = num_1 - num_2;
                num_1 = num_1 - num_2;
                Console.WriteLine($"Number 1: {num_1}");
                Console.WriteLine($"Number 2: {num_2}");
            }
            else
            {
                Console.WriteLine("You made a mistake while entering numbers");
            }
        }
    }
}
