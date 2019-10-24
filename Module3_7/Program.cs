using System;

namespace Module3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the array");
            bool check = int.TryParse(Console.ReadLine(), out int length);
            if (check && length > 0)
            {
                int[] dataArray = new int[length];
                Random random = new Random();
                for (int i = 0; i < length; i++)
                {
                    dataArray[i] = random.Next(-20,20);
                }
                Console.Write("Array of source data: ");
                for (int i = 0; i < dataArray.Length; i++)
                {
                    Console.Write($"{dataArray[i]} ");
                }
                Console.Write($"\nThe numbers in the array are larger than before them ");
                for (int i = 1; i < dataArray.Length; i++)
                {
                    if (dataArray[i-1] < dataArray[i])
                    {
                        Console.Write($"{dataArray[i]} ");
                    }
                }
            }
            else
            {
                Console.WriteLine("You made a mistake in inputting, or array length can`t be less than zero!");
            }
        }
    }
}
