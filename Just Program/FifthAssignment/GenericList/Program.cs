using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double salary { get; set; }
    }
    internal class genericList
    {
        public static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();
            Employee emp1 = new Employee()
            {
                Id = 1,
                Name = "Rohit",
                salary = 40000
            };
            Employee emp2 = new Employee()
            {
                Id = 2,
                Name = "abc",
                salary = 35000
            };
            Employee emp3 = new Employee()
            {
                Id = 3,
                Name = "xyz",
                salary = 45000
            };
            empList.Add(emp1);
            empList.Add(emp2);
            empList.Add(emp3);
            foreach (Employee e in empList)
            {
                Console.WriteLine("{0} {1} {2} \n", e.Id, e.Name, e.salary);
            }
            Console.WriteLine("Total Number of Employees {0}", empList.Count);
            Console.ReadLine();
        }
    }
}