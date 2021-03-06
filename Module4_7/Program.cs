﻿using System;

namespace Module4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter count of array elements");
            if (int.TryParse(Console.ReadLine(), out int count) && count > 0)
            {
                var rnd = new Random();
                int[] array = new int[count];
                Console.WriteLine("Initail array");
                for (int i = 0; i < count; i++)
                {
                    array[i] = rnd.Next(-10, 10);
                    Console.Write($"{array[i]} ");
                }
                Console.WriteLine("\nChoose direction for sort array");
                Console.WriteLine("1. Ascending");
                Console.WriteLine("2. Descending");
                string choose = Console.ReadLine().ToLower();
                bool isCorrectChoose = false;
                if (choose == "1" || choose == "ascending")
                {
                    SortArray(array);
                    isCorrectChoose = true;
                }
                else if (choose == "2" || choose == "descending")
                {
                    SortArray(array, choose.ToLower());
                    isCorrectChoose = true;
                }
                if (isCorrectChoose)
                {
                    Console.WriteLine($"Result of array sort by {(choose == "1" || choose == "ascending" ? "ascending" : "descending")}");
                    for (int i = 0; i < count; i++)
                    {
                        Console.Write($"{array[i]} ");
                    }
                }
                else
                {
                    Console.WriteLine("You choose wasn`t correct");
                }
            }
        }
        static void SortArray(int[] array, string direction = "1")
        {
            Array.Sort(array);
            if (direction == "descending" || direction == "2")
            {
                Array.Reverse(array);
            }
        }
    }
}
