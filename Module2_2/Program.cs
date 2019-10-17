using System;

namespace Module2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the integer number");
            int n = int.Parse(Console.ReadLine());
            if (n >= 18 && n % 2 == 0)
            {
                Console.WriteLine("Сongratulations on coming of age");
            }
            if (n < 18 && n % 2 != 0 && n >= 13)
            {
                Console.WriteLine("Congratulation on starting  high school");
            }
        }
    }
}
