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
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value of tax");
            double M = double.Parse(Console.ReadLine())/100.0;
            double income = 500;
            double amountTax = income * M * N;
            Console.WriteLine($"Amount tax for state {amountTax}");

        }
    }
}
