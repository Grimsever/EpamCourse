using System;

namespace Module4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers, which you would like to addition");
            Console.WriteLine($"The adition result is {GetSum(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()))}");

            Console.WriteLine("Enter three numbers to addition");
            Console.WriteLine($"The result of adding three numbers is {GetSum(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()))}");

            Console.WriteLine("Enter three fractional numbers to addition in format '2,2'");
            Console.WriteLine($"The resul of adding three fractional numbers is {GetSum(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()))}");

            Console.WriteLine("Enter two strings to addition");
            Console.WriteLine($"The resul of adding two strings is {GetSum(Console.ReadLine(), Console.ReadLine())}");

            Console.WriteLine("Enter the length first array");
            int.TryParse(Console.ReadLine(), out int countFirst);
            Console.WriteLine("Enter the length second array");
            int.TryParse(Console.ReadLine(), out int countSec);

            int[] firstArray, secArray;
            if (countFirst > countSec)
            {
                secArray = new int[countFirst];
                firstArray = new int[countFirst];
            }
            else
            {
                secArray = new int[countSec];
                firstArray = new int[countSec];
            }

            Console.WriteLine("Enter the first array elements");
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (i > countFirst - 1)
                    firstArray[i] = 0;
                else
                    firstArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the second array elements");
            for (int i = 0; i < secArray.Length; i++)
            {
                if (i < countSec)
                {
                    secArray[i] = int.Parse(Console.ReadLine());
                }
                else
                    secArray[i] = 0;
            }
            Console.WriteLine("The resul of adding two arrays elements is");
            GetSum(firstArray, secArray, out int[] resultArray);
            for (int i = 0; i < resultArray.Length; i++)
            {
                Console.Write($"{resultArray[i]} ");
            }

        }
        private static int GetSum(int firstNumb, int secNumb)
        {
            return firstNumb + secNumb;
        }
        private static int GetSum(int firstNumb, int secNumb, int thirdNumb)
        {
            return firstNumb + secNumb + thirdNumb;
        }
        private static double GetSum(double firstNumb, double secNumb, double thirdNumb)
        {
            return firstNumb + secNumb + thirdNumb;
        }
        private static string GetSum(string firstString, string secString)
        {
            return firstString + secString;
        }
        private static void GetSum(int[] firstArray, int[] secArray, out int[] resultArray)
        {
            resultArray = new int[firstArray.Length];
            for (int i = 0; i < resultArray.Length; i++)
            {
                resultArray[i] = firstArray[i] + secArray[i];
            }
        }
    }

}
