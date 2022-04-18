using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5GenericCollections
{
    class employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public double EmpSal { get; set; }

    }
    internal class arrayList
    {
        public static void Main(string[] args)
        {
            ArrayList a = new ArrayList();
            employee e1 = new employee();
            Console.WriteLine("Enter employee Id");
            e1.EmpId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter employee Name");
            e1.EmpName = Console.ReadLine();
            Console.WriteLine("Enter employee salary");
            e1.EmpSal = Convert.ToInt32(Console.ReadLine());
            a.Add(e1);
            foreach (employee e in a)
            {
                Console.WriteLine(e.EmpId + " " + e.EmpName + "" + e.EmpSal);
            }
            Console.ReadKey();
        }
    }
}