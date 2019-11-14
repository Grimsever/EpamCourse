using System;

namespace Module3_8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"You have a function: f(x)=2x-3");
            Console.WriteLine("Enter the accuracy");
            bool isCorrect = double.TryParse(Console.ReadLine(), out double accuracy);
            Console.WriteLine("Enter the start and the end of segment");
            if (isCorrect && double.TryParse(Console.ReadLine(), out double start) && double.TryParse(Console.ReadLine(), out double end))
            {
                if (GetFunction(start) * GetFunction(end) < 0)
                {
                    double xI = 0;
                    while (Math.Abs(end - start) > accuracy)
                    {
                        double dx = (end - start) / 2.0;
                        xI = start + dx;
                        if (Math.Sign(GetFunction(start)) != Math.Sign(GetFunction(xI)))
                        {
                            end = xI;
                        }
                        else
                        {
                            start = xI;
                        }
                    }
                    Console.WriteLine($"Solution the function is x= {xI}");
                }
                else
                {
                    Console.WriteLine("Segment that you inputting is not correct");
                }
            }
            else
            {
                Console.WriteLine("You made mistake in inputting!!");
            }
        }
        private static double GetFunction(double x)
        {
            return 2 * x - 3;
        }
    }
}
