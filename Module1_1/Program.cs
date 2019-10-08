using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value number a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value number b");
            int b = Convert.ToInt32(Console.ReadLine());
            a = b + a;
            b = a - b;
            a = a - b;
            Console.WriteLine($"Value a={a}");
            Console.WriteLine($"Value b={b}");
        }
    }
}
