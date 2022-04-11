using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.HighestMarks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[5];
            int max=0;
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter average marks of {0} Student: ",i+1);
                marks[i]=Convert.ToInt32(Console.ReadLine());
                if (i == 0)
                {
                    max=marks[0];
                }
                else if (max<marks[i])
                {
                    max=marks[i];
                }
            }
            Console.WriteLine("Highest marks obtained {0}",max);
        }
    }
}
