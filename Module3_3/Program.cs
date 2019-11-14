using System;

namespace Module3_3
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine ("Enter the count of fibonacci numbers");
            if (int.TryParse (Console.ReadLine (), out int countOfFibonacciNumbers))
            {
                int temp;
                if (countOfFibonacciNumbers > 0)
                {
                    Console.Write("Numbers of Fibonacci: ");
                    for (int i = 0; i < countOfFibonacciNumbers; i++)
                    {
                        int firstNumberOfFibonacci = 0;
                        int secondNumberOfFibonacci = 1;
                        for (int j = 0; j < i; j++)
                        {
                            temp = firstNumberOfFibonacci;
                            firstNumberOfFibonacci = secondNumberOfFibonacci;
                            secondNumberOfFibonacci += temp;
                        }
                        Console.Write($"{firstNumberOfFibonacci} ");
                    }
                }
            }
            else
            {
                Console.WriteLine("You made a mistake in inputting");
            }
        }
    }
}
