using System;

namespace Module4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers, which you would like to addition");
            if (int.TryParse(Console.ReadLine(), out int firstNum) && int.TryParse(Console.ReadLine(), out int secNum))
            {
                Console.WriteLine($"The adition result is {GetSum(firstNum, secNum)}");
            }
            else
            {
                Console.WriteLine("You made a mistake in inputting");
            }

            Console.WriteLine("Enter three numbers to addition");
            if (int.TryParse(Console.ReadLine(), out firstNum) && int.TryParse(Console.ReadLine(), out secNum) && int.TryParse(Console.ReadLine(), out int thirdNum))
            {
                Console.WriteLine($"The result of adding three numbers is {GetSum(firstNum, secNum, thirdNum)}");
            }
            else
            {
                Console.WriteLine("You made a mistake in inputting");
            }

            Console.WriteLine("Enter three fractional numbers to addition(if you will use fractional numbers, enter them in the format '0.0')");
            if (double.TryParse(Console.ReadLine(), out double firstNumb) && double.TryParse(Console.ReadLine(), out double secNumb) && double.TryParse(Console.ReadLine(), out double thirdNumb))
            {
                Console.WriteLine($"The resul of adding three fractional numbers is {GetSum(firstNumb, secNumb, thirdNumb)}");
            }
            else
            {
                Console.WriteLine("You made a mistake in inputting");
            }

            Console.WriteLine("Enter two strings to addition");
            Console.WriteLine($"The resul of adding two strings is {GetSum(Console.ReadLine(), Console.ReadLine())}");

            Console.WriteLine("Enter the length first array");
            Console.WriteLine("Enter the length second array");
            if (int.TryParse(Console.ReadLine(), out int countFirst) && countFirst > 0 && int.TryParse(Console.ReadLine(), out int countSec) && countSec > 0)
            {
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
                    {
                        firstArray[i] = 0;
                    }
                    else
                    {
                        if (int.TryParse(Console.ReadLine(), out int num))
                        {
                            firstArray[i] = num;
                        }
                        else
                        {
                            i--;
                            Console.WriteLine("You made a mistake in inputting");
                        }
                    }
                }

                Console.WriteLine("Enter the second array elements");
                for (int i = 0; i < secArray.Length; i++)
                {
                    if (i < countSec)
                    {
                        if (int.TryParse(Console.ReadLine(), out int num))
                        {
                            secArray[i] = num;
                        }
                        else
                        {
                            i--;
                            Console.WriteLine("You made a mistake in inputting");
                        }
                    }
                    else
                    {
                        secArray[i] = 0;
                    }
                }
                Console.WriteLine("Initial arrays are: ");
                for (int i = 0; i < firstArray.Length; i++)
                {
                    Console.Write($"{firstArray[i]} ");
                }
                Console.WriteLine();
                for (int i = 0; i < secArray.Length; i++)
                {
                    Console.Write($"{secArray[i]} ");
                }
                Console.WriteLine("\nThe resul of adding two arrays elements is");
                GetSum(firstArray, secArray, out int[] resultArray);
                for (int i = 0; i < resultArray.Length; i++)
                {
                    Console.Write($"{resultArray[i]} ");
                }
            }
            else
            {
                Console.WriteLine("You made a mistake in inputting, or length array can`t be less zero");
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
