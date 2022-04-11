using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number:");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Addition: {0}", a + b);
            Console.WriteLine("Subtraction: {0}", a - b);
            Console.WriteLine("Multiplication: {0}", a * b);
            Console.WriteLine("Division: {0}", a / b);

        }
    }
}
