using System;

namespace Module4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter count of array elements");
            int.TryParse(Console.ReadLine(), out int count);
            var rnd = new Random();
            var array = new int[count];
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
            if (choose == "1" || choose == "ascending")
            {
                SortArray(array);
            }
            else
            {
                SortArray(array, choose.ToLower());
            }
            Console.WriteLine($"Result of array sort by {(choose == "1" || choose == "ascending" ? "ascending" : "descending")}");
            for (int i = 0; i < count; i++)
            {
                Console.Write($"{array[i]} ");
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
