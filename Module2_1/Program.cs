using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of companies");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value of tax");
            double m = double.Parse(Console.ReadLine())/100.0;
            double income = 500;
            double amountTax = income * m * n;
            Console.WriteLine($"Amount tax for state {amountTax}");

        }
    }
}
