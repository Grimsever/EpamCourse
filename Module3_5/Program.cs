using System;

namespace Module3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the natural number and numeric which you wnat to delete");
            if (int.TryParse(Console.ReadLine(), out int naturalNumber) && int.TryParse(Console.ReadLine(), out int numbForDelete))
            {
                string number = naturalNumber.ToString();
                string numeric = numbForDelete.ToString();
                string result = "";
                for (int i = 0; i < number.Length; i++)
                {
                    if (number[i].ToString() != numeric)
                    {
                        result += number[i];
                    }
                }
                int newNumber = int.Parse(result);
                Console.WriteLine($"Result {newNumber}");
            }
            else
            {
                Console.WriteLine("You made a mistake in inputting");
            }
            
        }
    }
}
