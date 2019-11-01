using System;

namespace Module4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter count array elemts");
            if (int.TryParse(Console.ReadLine(), out int count) && count > 0)
            {
                int[] array = new int[count];
                var rnd = new Random();
                Console.WriteLine("Initail array elements: ");
                for (int i = 0; i < count; i++)
                {
                    array[i] = rnd.Next(-10, 10);
                    Console.Write($"{array[i]} ");
                }
                SetNewValueInArray(array);
                Console.WriteLine("\nResult of increasing array elements by 5: ");
                for (int i = 0; i < count; i++)
                {
                    Console.Write($"{array[i]} ");
                }
            }
            else
            {
                Console.WriteLine("You made a mistake int inputting or count can`t be less zero");
            }
        }

        static void SetNewValueInArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += 5;
            }
        }
    }
}
