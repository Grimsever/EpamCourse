using System;

namespace Module3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of array");
            if (int.TryParse(Console.ReadLine(),out int length) && length > 0)
            {
                double[] dataArray = new double[length];
                Random random = new Random();
                for (int i = 0; i < length; i++)
                {
                    dataArray[i] = random.Next(-20, 20);
                }
                Console.WriteLine($"Initial data array: ");
                for (int i = 0; i < dataArray.Length; i++)
                {
                    Console.Write($"{dataArray[i]} ");
                }
                Console.WriteLine("\nArray of data after change: ");
                for (int i = 0; i < dataArray.Length; i++)
                {
                    dataArray[i] *= -1;
                    Console.Write($"{dataArray[i]} ");
                }
            }
            else
            {
                Console.WriteLine("Array length can`t be less than zero, or you made mistake in inputting");
            }
        }
    }
}
