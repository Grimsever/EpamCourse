using System;

namespace Module4_5
{
    class Program
    {
        enum Operation
        {
            Add,
            Subtract,
            Multiply,
            Divide
        }
        enum Month
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers for operation");
            if (double.TryParse(Console.ReadLine(), out double numFirst) && double.TryParse(Console.ReadLine(), out double numSec))
            {
                ShowResultOfMathOp(numFirst, numSec, Operation.Add);
                ShowResultOfMathOp(numFirst, numSec, Operation.Subtract);
                ShowResultOfMathOp(numFirst, numSec, Operation.Multiply);
                ShowResultOfMathOp(numFirst, numSec, Operation.Divide);
            }
            else
            {
                Console.WriteLine("You made a mistake in inputting");
            }

            Console.WriteLine("\nEnter month number");
            if (int.TryParse(Console.ReadLine(), out int monthNumber) && monthNumber > 0 && monthNumber <= 12)
            {
                switch (monthNumber)
                {
                    case 1:
                        ShowCoutDays(Month.January);
                        break;
                    case 2:
                        ShowCoutDays(Month.February);
                        break;
                    case 3:
                        ShowCoutDays(Month.March);
                        break;
                    case 4:
                        ShowCoutDays(Month.April);
                        break;
                    case 5:
                        ShowCoutDays(Month.May);
                        break;
                    case 6:
                        ShowCoutDays(Month.June);
                        break;
                    case 7:
                        ShowCoutDays(Month.July);
                        break;
                    case 8:
                        ShowCoutDays(Month.August);
                        break;
                    case 9:
                        ShowCoutDays(Month.September);
                        break;
                    case 10:
                        ShowCoutDays(Month.October);
                        break;
                    case 11:
                        ShowCoutDays(Month.November);
                        break;
                    case 12:
                        ShowCoutDays(Month.December);
                        break;
                }
            }
            else
            {
                Console.WriteLine("You made mistake in inputting, and month number can`t be less 1 and more 12");
            }
        }
        static void ShowCoutDays(Month month)
        {
            Console.WriteLine($"In {month} {new DateTime(2019, (int)month, 1).AddMonths(1).AddDays(-1).Day} days");
        }
        static void ShowResultOfMathOp(double numFirs, double numSec, Operation operation)
        {
            double result = 0;

            switch (operation)
            {
                case Operation.Add:
                    result = numFirs + numSec;
                    break;
                case Operation.Subtract:
                    result = numFirs - numSec;
                    break;
                case Operation.Multiply:
                    result = numFirs * numSec;
                    break;
                case Operation.Divide:
                    result = numFirs / numSec;
                    break;
            }

            Console.WriteLine($"Result of {operation} is {result}");
        }
    }
}
