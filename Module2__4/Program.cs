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
            double.TryParse(Console.ReadLine(), out double R);
            switch (select)
            {
                case "1":
                    OutputDataOfTriangle(parameter, R);
                    Console.WriteLine("\nAnd parametrs in other figures\n");
                    OutputDataOfSquare(parameter, R);
                    OutputDataOfCircle(parameter, R);

                    break;
                case "2":
                    OutputDataOfCircle(parameter, R);
                    Console.WriteLine("\nAnd parametrs in other figures\n");
                    OutputDataOfTriangle(parameter, R);
                    OutputDataOfSquare(parameter, R);
                    break;
                case "3":
                    OutputDataOfSquare(parameter, R);
                    Console.WriteLine("\nAnd parametrs in other figures\n");
                    OutputDataOfCircle(parameter, R);
                    OutputDataOfTriangle(parameter, R);
                    break;
                default:
                    Console.WriteLine("You made a mistake in input");
                    break;
            }
        }
        static void OutputDataOfTriangle(string param, double R)
        {
            if (param == "1")
            {
                double S = 3 * Math.Sqrt(3) * R * R;
                double p = 2 * S / R;
                Console.WriteLine($"The area of triangle is {S}");
                Console.WriteLine($"And the perimetr is {p}");
            }
            else if(param=="2")
            {
                double S = 3 * Math.Sqrt(3) * R * R;
                double p = 2 * S / R;
                Console.WriteLine($"The perimetr is {p}");
                Console.WriteLine($"And the area of triangle is {S}");
            }
            else
                Console.WriteLine("You made a mistake in input");
        }
        static void OutputDataOfCircle(string param, double R)
        {
            if (param == "1")
            {
                double S = Math.PI * R * R;
                Console.WriteLine($"The area of circle is {S}");
                double P = 2 * Math.PI * R;
                Console.WriteLine($"And the perimetr of circle is {P}");
            }
            else if (param == "2")
            {
                double P = 2 * Math.PI * R;
                Console.WriteLine($"The perimetr of circle is {P}");
                double S = Math.PI * R * R;
                Console.WriteLine($"And the area of circle is {S}");
            }
            else
                Console.WriteLine("You made a mistake in input");
        }
        static void OutputDataOfSquare(string param, double R)
        {
            if (param == "1")
            {
                double S = 4 * R * R;
                Console.WriteLine($"The area of square is {S}");
                double P = 8 * R;
                Console.WriteLine($"And the perimetr of square is {P}");
            }
            else if (param == "2")
            {
                double P = 8 * R;
                Console.WriteLine($"The perimetr of square is {P}");
                double S = 4 * R * R;
                Console.WriteLine($"And the area of square is {S}");
            }
            else
                Console.WriteLine("You made a mistake in input");
        }
    }
}
