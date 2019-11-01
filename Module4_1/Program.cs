using System;

namespace Module4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the count of numbers in array");
            if (int.TryParse(Console.ReadLine(), out int count) && count>0)
            {
                double[] array = new double[count];
                Random rand = new Random();
                Console.WriteLine("Initail array");
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rand.Next(-10, 10);
                    Console.Write($"{array[i]} ");
                }
                double max = GetMaxArrayElement(array);
                double min = GetMinArrayElement(array);
                Console.WriteLine($"\nMaximum number in the array is {max}");
                Console.WriteLine($"Minimum number in the array is {min}");
                Console.WriteLine($"Sum of the array elemetns is {GetSumOfArrayElements(array)}");
                Console.WriteLine($"\nThe difference between the maximum and minimum elements of array is {GetDifferenceBetweenMaxAndMin(max, min)}");
                Console.WriteLine($"\nThe result after increase even elements on the maximum \nand decrease uneven elements on the minimum of initail array");
                GetArrayAfterIncreaseAndDecrease(array, max, min);
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i]} ");
                }
            }
            else
            {
                Console.WriteLine("You made mistake in inputting, or count can`t be less zero");
            }
        }
        private static double GetMaxArrayElement(double[] array)
        {
            double max=double.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
        private static double GetMinArrayElement(double[] array)
        {
            double min = double.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }
        private static double GetSumOfArrayElements(double[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        private static double GetDifferenceBetweenMaxAndMin(double max, double min)
        {
            return max - min;
        }
        private static void GetArrayAfterIncreaseAndDecrease(double[] array, double max,double min)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    array[i] += max;
                }
                else
                    array[i] -= min;
            }
        }

    }
}
