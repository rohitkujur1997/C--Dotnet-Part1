using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5GenericCollections
{
    class Main
    {
        public void printarray(int[] integeraaray)
        {
            foreach (var item in integeraaray)
            {
                Console.Write("{0} ", item);
            }
        }
        public void printarray(string[] stringarray)
        {
            foreach (var item in stringarray)
            {
                Console.Write("{0} ", item);
            }
        }
        public void Display()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] integerarray = new int[5];
            int[] integerarray1 = new int[5];
            string[] stringarray = new string[5];
            string[] stringarray1 = new string[5];
            Console.WriteLine("Enter the 5 array elements");
            for (int i = 0; i < integerarray.Length; i++)
            {
                integerarray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter the 5 String elements");
            for (int i = 0; i < stringarray.Length; i++)
            {
                stringarray[i] = Console.ReadLine();
            }
            Main m1 = new Main();
            Console.WriteLine("Array List are : ");
            m1.printarray(integerarray);
            Console.WriteLine();

            Console.WriteLine("\nString elements are :");
            m1.printarray(stringarray);
            Console.WriteLine();

            //Reversing an Array
            Array.Reverse(integerarray);
            Console.WriteLine("\nAfter Reversing the Array :");
            m1.printarray(integerarray);
            Console.WriteLine();

            //Sorting a Array
            Array.Sort(integerarray);
            Console.WriteLine("\nAfter Sorting the Array :");
            m1.printarray(integerarray);
            Console.WriteLine();

            //Clear the array elements
            Array.Clear(integerarray, 1, 2);
            Console.WriteLine("\nAfter Clearing the Array :");
            m1.printarray(integerarray);
            Console.WriteLine();

            //Copying the array elements
            Array.Copy(integerarray, integerarray1, 5);
            Console.WriteLine("\nAfter Copying the Array :");
            m1.printarray(integerarray);
            Console.WriteLine();

            //Reversing an String
            Array.Reverse(stringarray);
            Console.WriteLine("\nAfter Reversing the Array :");
            m1.printarray(stringarray);
            Console.WriteLine();

            //Sorting a String
            Array.Sort(stringarray);
            Console.WriteLine("\nAfter Sorting the Array :");
            m1.printarray(stringarray);
            Console.WriteLine();

            //Clear the String elements
            Array.Clear(stringarray, 1, 2);
            Console.WriteLine("\nAfter Clearing the Array : ");
            m1.printarray(stringarray);
            Console.WriteLine();

            //Copying the String elements
            Array.Copy(stringarray, stringarray1, 5);
            Console.WriteLine("\nAfter Copying the Array :");
            m1.printarray(stringarray);
            Console.WriteLine();


            Console.ReadKey();
        }
    }


}