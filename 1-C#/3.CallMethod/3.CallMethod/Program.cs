using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CallMethod
{
    internal class Program
    {
        static void ClientMethod(int[] integer)
        {
            int sum=0;
            for (int i = 0; i < integer.Length; i++)
                sum += integer[i];
            Console.WriteLine("Sum of all integers {0}", sum);
        }
        static void Main(string[] args)
        {
            int[] integer = new int[5];
            for (int i = 0; i < integer.Length; i++)
                integer[i] = Convert.ToInt32(Console.ReadLine());
            ClientMethod(integer);
        }
    }
}
