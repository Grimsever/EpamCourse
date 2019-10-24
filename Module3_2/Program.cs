using System;

namespace Module3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter count of natural numbers");
            if (int.TryParse(Console.ReadLine(), out int countOfNumbers))
            {
                int count = 0;
                int naturalNumber = 0;
                Console.Write("Even natural numbers: ");
                while (count != countOfNumbers)
                {
                    Console.Write($"{naturalNumber += 2} ");
                    count++;
                }
            }
            else
            {
                Console.WriteLine("You made a mistake in inputting");
            }
        }
    }
}
