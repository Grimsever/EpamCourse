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
            switch (select)
            {
                case "1":
                    OutputDataOfTriangle(parameter);
                    break;
                case "2":
                    OutputDataOfCircle(parameter);
                    break;
                case "3":
                    OutputDataOfSquare(parameter);
                    break;
                default:
                    Console.WriteLine("You made a mistake");
                    break;
            }
            

        }
        static void OutputDataOfTriangle(string param)
        {
            Console.WriteLine("Enter the first side of the triangle");
            double.TryParse(Console.ReadLine(), out double a);
            Console.WriteLine("Enter the second side of the triangle");
            double.TryParse(Console.ReadLine(), out double b);
            Console.WriteLine("Enter the third side of the triangle");
            double.TryParse(Console.ReadLine(), out double c);
            if (param == "1")
            {
                double p = a + b + c;
                double S = Math.Sqrt(p / 2 * (p / 2 - a) * (p / 2 - b) * (p / 2 - c));
                Console.WriteLine($"The area of triangle is {S}");
                Console.WriteLine($"And the perimetr is {p}");
            }
            else
            {
                double p = a + b + c;
                Console.WriteLine($"The perimetr is {p}");
                double S = Math.Sqrt(p / 2 * (p / 2 - a) * (p / 2 - b) * (p / 2 - c));
                Console.WriteLine($"And the area of triangle is {S}");
            }
        }
        static void OutputDataOfCircle(string param)
        {
            Console.WriteLine("Enter the radius of circle");
            double.TryParse(Console.ReadLine(),out double R);
            
            if (param == "1")
            {
                double S = Math.PI * R * R;
                Console.WriteLine($"The area of circle is {S}");
                double P = 2 * Math.PI * R;
                Console.WriteLine($"And the perimetr of circle is {P}");
            }
            if(param=="2")
            {
                double P = 2 * Math.PI * R;
                Console.WriteLine($"The perimetr of circle is {P}");
                double S = Math.PI * R * R;
                Console.WriteLine($"And the area of circle is {S}");
            }

        }
        static void OutputDataOfSquare(string param)
        {
            Console.WriteLine("Enter the side of square");
            double.TryParse(Console.ReadLine(), out double a);

            if (param == "1")
            {
                double S = a*a;
                Console.WriteLine($"The area of square is {S}");
                double P = 4*a;
                Console.WriteLine($"And the perimetr of square is {P}");
            }
            if (param == "2")
            {
                double P = 4*a;
                Console.WriteLine($"The perimetr of square is {P}");
                double S = a*a;
                Console.WriteLine($"And the area of square is {S}");
            }

        }

    }

}
