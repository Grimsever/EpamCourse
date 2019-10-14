using System;

namespace Module2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the integer number");
            int N = int.Parse(Console.ReadLine());
            if (N >= 18 && N % 2 == 0)
            {
                Console.WriteLine("Сongratulations on coming of age");
            }
            if (N < 18 && N % 2 != 0 && N >= 13)
            {
                Console.WriteLine("Congratulation on starting  high school");
            }
        }
    }
}
