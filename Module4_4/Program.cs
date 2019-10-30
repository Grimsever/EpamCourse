using System;

namespace Module4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers to addition");
            int.TryParse(Console.ReadLine(), out int firstNumb);
            int.TryParse(Console.ReadLine(), out int secNumb);
            int.TryParse(Console.ReadLine(), out int thirdNumb);
            (int, int, int) numbers = (firstNumb, secNumb, thirdNumb);
            GetNewNumberAfterAdd(ref numbers);
            Console.WriteLine($"The result of addition new numbers: {numbers.Item1} {numbers.Item2} {numbers.Item3}");
            Console.WriteLine($"Enter circle radius");
            (double area, double length) paramOfCircle = (area: 0, length: 0);
            GetParametersOfCircle(double.Parse(Console.ReadLine()), ref paramOfCircle);
            Console.WriteLine($"The circle has parameters for area: {paramOfCircle.area.ToString("F")} and length: {paramOfCircle.length.ToString("F")}");
            Console.WriteLine("\nEnter the count of array elements");
            int.TryParse(Console.ReadLine(), out int count);
            int[] array = new int[count];
            Random rnd = new Random();
            Console.WriteLine("Initial array:");
            for (int i = 0; i < count; i++)
            {
                array[i] = rnd.Next(-10, 10);
                Console.Write(array[i] + " ");
            }
            var arrayParam = (min: int.MaxValue, max: int.MinValue, sum: 0);
            GetArrayParam(array, ref arrayParam);
            Console.WriteLine($"\nAmount of the array elements is {arrayParam.sum} max element is {arrayParam.max} min element is {arrayParam.min}");

        }
        private static void GetNewNumberAfterAdd(ref (int, int, int) numbers)
        {
            numbers.Item1 += 10;
            numbers.Item2 += 10;
            numbers.Item3 += 10;
        }

        private static void GetParametersOfCircle(double r, ref (double area, double length) param)
        {
            param.area = Math.PI * r * r;
            param.length = 2 * Math.PI * r;
        }
        private static void GetArrayParam(int[] array, ref (int min, int max, int sum) outData)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (outData.max < array[i])
                    outData.max = array[i];
                else if (outData.min > array[i])
                    outData.min = array[i];
                outData.sum += array[i];
            }
        }
    }
}
