using System;

namespace Module3_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array");
            if (int.TryParse(Console.ReadLine(), out int size) && size > 1)
            {
                var array = new int[size, size];
                Console.WriteLine();
                int pointByI, pointByJ, iStep, jStep;
                if (size % 2 == 0)
                {
                    pointByI = array.GetLength(0) / 2;
                    pointByJ = array.GetLength(0) / 2 - 1;
                    iStep = 1;
                    jStep = -1;
                }
                else
                {
                    pointByI = array.GetLength(0) / 2;
                    pointByJ = array.GetLength(0) / 2;
                    iStep = -1;
                    jStep = 1;
                }
                int numberToArray = size * size;
                array[pointByI, pointByJ] = numberToArray--;
                for (int i = 0; i < size; i++)
                {
                    for (int h = 0; h < i; h++)
                        array[pointByI, pointByJ += jStep] = numberToArray--;
                    for (int v = 0; v < i; v++)
                        array[pointByI += iStep, pointByJ] = numberToArray--;
                    jStep = -jStep;
                    iStep = -iStep;
                }
                for (int h = 0; h < array.GetLength(0) - 1; h++)
                    array[pointByI, pointByJ += jStep] = numberToArray--;
                Console.WriteLine();
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write($"{array[i, j]}\t");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Array size can`t be less 1");
            }
        }
    }
}
