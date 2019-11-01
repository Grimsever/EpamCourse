using System;

namespace Module4_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You have a function: f(x)=2*x-1");
            Console.WriteLine("Enter the accuracy (in format 0.0)");
            if (double.TryParse(Console.ReadLine(), out double accuracy))
            {
                Console.WriteLine("Enter the start and the end of segment");
                if (double.TryParse(Console.ReadLine(), out double start) && double.TryParse(Console.ReadLine(), out double end))
                {
                    if (GetFunction(start) * GetFunction(end) < 0)
                    {
                        double xI = GetValueX(start, end, accuracy);
                        Console.WriteLine($"Solution the function is x= {xI}");
                    }
                    else
                    {
                        Console.WriteLine("Segment that you inputting is not correct");
                    }
                }
                else
                {
                    Console.WriteLine("You made mistake in inputting");
                }
            }
            else
            {
                Console.WriteLine("You made mistake in inputting");
            }
        }
        static double GetValueX(double start, double end, double accuracy)
        {
            double x;
            if (Math.Abs(end - start) <= accuracy)
            {
                return (start + end) / 2.0;
            }
            else
            {
                x = (start + end) / 2.0;
                if (Math.Sign(GetFunction(start))!= Math.Sign(GetFunction(x)))
                {
                    return GetValueX(start, x, accuracy);
                }
                else
                {
                    return GetValueX(x, end, accuracy);
                }
            }
        }

        static double GetFunction(double x)
        {
            return 2 * x - 1;
        }
    }
}


