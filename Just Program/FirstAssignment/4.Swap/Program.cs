using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Swap
{
    internal class Program
    {
        static void Swap(int a,int b)
        {
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("A: {0}\nB: {1}",a,b);
        }
        static void Main(string[] args)
        {
            int a,b;
            Console.WriteLine("A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B: ");
            b = Convert.ToInt32(Console.ReadLine());
            Swap(a, b);
        }
    }
}
