using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.AreaCircumference
{
    internal class Program
    {
        static void Solution(float r)
        {
            float area, circumference, pie=3.14F;
            area = pie * r * r;
            Console.WriteLine("Area of Circle {0}", area);
            circumference = 2 * pie * r;
            Console.WriteLine("Circumference of Circle {0}", circumference);
        }
        static void Main(string[] args)
        {
            float r;
            Console.WriteLine("Enter Circle Radius: ");
            r= Single.Parse(Console.ReadLine());
            Solution(r);
        }
    }
}
