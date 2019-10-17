using System;

namespace Module2__4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a figure");
            Console.WriteLine("1. Triangle");
            Console.WriteLine("2. Circle");
            Console.WriteLine("3. Square");
            string select = Console.ReadLine();
            Console.WriteLine("Please choose parameter for calculation");
            Console.WriteLine("1. Area");
            Console.WriteLine("2. Perimetr");
            string parameter = Console.ReadLine();
            Console.WriteLine("Enter radius of the inscribed circle");
            double.TryParse(Console.ReadLine(), out double r);
            switch (select)
            {
                case "1":
                    OutputDataOfTriangle(parameter, r);
                    Console.WriteLine("\nAnd parametrs in other figures\n");
                    OutputDataOfSquare(parameter, r);
                    OutputDataOfCircle(parameter, r);

                    break;
                case "2":
                    OutputDataOfCircle(parameter, r);
                    Console.WriteLine("\nAnd parametrs in other figures\n");
                    OutputDataOfTriangle(parameter, r);
                    OutputDataOfSquare(parameter, r);
                    break;
                case "3":
                    OutputDataOfSquare(parameter, r);
                    Console.WriteLine("\nAnd parametrs in other figures\n");
                    OutputDataOfCircle(parameter, r);
                    OutputDataOfTriangle(parameter, r);
                    break;
                default:
                    Console.WriteLine("You made a mistake in input");
                    break;
            }
        }
        static void OutputDataOfTriangle(string param, double r)
        {
            if (param == "1")
            {
                double s = 3 * Math.Sqrt(3) * r * r;
                double p = 2 * s / r;
                Console.WriteLine($"The area of triangle is {s}");
                Console.WriteLine($"And the perimetr is {p}");
            }
            else if(param=="2")
            {
                double s = 3 * Math.Sqrt(3) * r * r;
                double p = 2 * s / r;
                Console.WriteLine($"The perimetr is {p}");
                Console.WriteLine($"And the area of triangle is {s}");
            }
            else
                Console.WriteLine("You made a mistake in input");
        }
        static void OutputDataOfCircle(string param, double r)
        {
            if (param == "1")
            {
                double s = Math.PI * r * r;
                Console.WriteLine($"The area of circle is {s}");
                double p = 2 * Math.PI * r;
                Console.WriteLine($"And the perimetr of circle is {p}");
            }
            else if (param == "2")
            {
                double p = 2 * Math.PI * r;
                Console.WriteLine($"The perimetr of circle is {p}");
                double s = Math.PI * r * r;
                Console.WriteLine($"And the area of circle is {s}");
            }
            else
                Console.WriteLine("You made a mistake in input");
        }
        static void OutputDataOfSquare(string param, double r)
        {
            if (param == "1")
            {
                double s = 4 * r * r;
                Console.WriteLine($"The area of square is {s}");
                double p = 8 * r;
                Console.WriteLine($"And the perimetr of square is {p}");
            }
            else if (param == "2")
            {
                double p = 8 * r;
                Console.WriteLine($"The perimetr of square is {p}");
                double s = 4 * r * r;
                Console.WriteLine($"And the area of square is {s}");
            }
            else
                Console.WriteLine("You made a mistake in input");
        }
    }
}
