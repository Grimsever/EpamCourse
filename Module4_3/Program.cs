﻿using System;

namespace Module4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers to addition");
            if (int.TryParse(Console.ReadLine(), out int firstNumb) && int.TryParse(Console.ReadLine(), out int secNumb) && int.TryParse(Console.ReadLine(), out int thirdNumb))
            {
                GetNewNumberAfterAdd(ref firstNumb, ref secNumb, ref thirdNumb);
                Console.WriteLine($"The result of addition new numbers: {firstNumb} {secNumb} {thirdNumb}");
            }
            else
            {
                Console.WriteLine("OOPS, you made a mistake in inputting");
            }

            Console.WriteLine("Enter circle radius");
            if (double.TryParse(Console.ReadLine(), out double rad) && rad > 0)
            {
                GetParametersOfCircle(rad, out double area, out double length);
                Console.WriteLine($"The circle has parameters for area: {area.ToString("F")} and length: {length.ToString("F")}");
            }
            else
            {
                Console.WriteLine("Radius can`t be less zero, or you made a mistake in inputting");
            }
            Console.WriteLine("Enter the count of array elements");
            if (int.TryParse(Console.ReadLine(), out int count) && count > 0)
            {
                double[] array = new double[count];
                Console.WriteLine("Initail array");
                var rnd = new Random();
                for (int i = 0; i < count; i++)
                {
                    array[i] = rnd.Next(-10, 10);
                    Console.Write($"{array[i]} ");
                }
                double max = double.MinValue;
                double min = double.MaxValue;
                double sum = 0;
                GetArrayParam(array, ref sum, ref max, ref min);
                Console.WriteLine($"\nAmount of the array elements is {sum} max element is {max} min element is {min}");
            }
            else
            {
                Console.WriteLine("Array length can`t be less zero, or you made a mistake in inputting");
            }
            
        }
        private static void GetNewNumberAfterAdd(ref int first, ref int second, ref int third)
        {
            first += 10;
            second += 10;
            third += 10;
        }
        private static void GetParametersOfCircle(double r, out double area, out double length)
        {
            area = Math.PI * r * r;
            length = 2 * Math.PI * r;
        }
        private static void GetArrayParam(double[] array, ref double sum, ref double max, ref double min)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                    max = array[i];
                else if (min > array[i])
                    min = array[i];
                sum += array[i];
            }
        }
    }
}
