using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesMulticast
{
    class _2MarketingExecuteDelegate
    {
        public class Employee
        {
            protected int EmpNo;
            protected string EmpName;
            protected double Salary;
            protected double HRA;
            protected double TA;
            protected double DA;
            protected double PF;
            protected double TDS;
            protected double NetSalary;
            protected double GrossSalary;

            public void SetEmpNo(int EmpNo)
            {
                this.EmpNo = EmpNo;
            }
            public void SetEmpName(string EmpName)
            {
                this.EmpName = EmpName;
            }
            public double SetSalary(double Salary)
            {
                this.Salary = Salary;
                if (this.Salary < 500)
                {
                    this.HRA = (this.Salary * 10) / 100;
                    this.TA = (this.Salary * 5) / 100;
                    this.DA = (this.Salary * 15) / 100;
                }
                else if (this.Salary > 5000 && this.Salary < 10000)
                {
                    this.HRA = (this.Salary * 15) / 100;
                    this.TA = (this.Salary * 10) / 100;
                    this.DA = (this.Salary * 20) / 100;
                }
                else if (this.Salary >= 10000 && this.Salary < 15000)
                {
                    this.HRA = (this.Salary * 20) / 100;
                    this.TA = (this.Salary * 15) / 100;
                    this.DA = (this.Salary * 25) / 100;
                }
                else if (this.Salary >= 15000 && this.Salary < 20000)
                {
                    this.HRA = (this.Salary * 25) / 100;
                    this.TA = (this.Salary * 20) / 100;
                    this.DA = (this.Salary * 30) / 100;
                }
                else
                {
                    this.HRA = (this.Salary * 30) / 100;
                    this.TA = (this.Salary * 25) / 100;
                    this.DA = (this.Salary * 35) / 100;
                }
                //Gross Salary
                return this.GrossSalary = this.Salary + this.HRA + this.TA + this.DA;

            }
            //Used virtual keyword this method can be over rided in the child class
            public virtual double CalculateSalary()
            {
                this.PF = (this.GrossSalary * 10) / 100;
                this.TDS = (this.GrossSalary * 18) / 100;
                this.NetSalary = this.GrossSalary - (this.PF + this.TDS);
                return this.NetSalary;
            }
            //This Method is the Implementation of the Iprintable Interface for printing Details
        }

        //Inheriting the properties of Employee
        public class Manager : Employee
        {
            //Delegate Creation
            public delegate double EmployeeDelegate();

            private double PetrolAllowance;
            private double FoodAllowance;
            private double OtherAllowances;

            public double SetSalary(double Salary)
            {
                base.SetSalary(Salary);
                this.PetrolAllowance = Salary * 8 / 100;
                this.FoodAllowance = Salary * 13 / 100;
                this.OtherAllowances = Salary * 3 / 100;
                return this.GrossSalary = base.GrossSalary + PetrolAllowance + FoodAllowance + OtherAllowances;
            }
            public override double CalculateSalary()
            {
                TDS = GrossSalary * 18 / 100;
                NetSalary = GrossSalary - TDS;
                return NetSalary;

            }
        }
        //Inheriting the properties of Employee
        class MarketingExecutive : Employee
        {
            //Delegate for Executive
            public delegate double EmployeeDelegate1();

            private double KilometerTravel;
            private double TourAllowances;
            private int TelephoneAllowances = 1000;

            //Created a Contructor and passed an argumen
            public void SetKilometersTravel(double Kilo)
            {
                KilometerTravel = Kilo;
                TourAllowances = KilometerTravel * 5;
            }
            public double SetSalary(double Salary)
            {
                base.SetSalary(Salary);
                return GrossSalary += TourAllowances + TelephoneAllowances;
            }
            //Overriding the CalculateSalary() Method of Employee
            public override double CalculateSalary()
            {
                TDS = GrossSalary * 18 / 100;
                NetSalary = GrossSalary - TDS;
                return NetSalary;

            }
        }
        static void Main(string[] args)
        {
            //Taking User Inputs of Employee id,name and salary
            Console.Write("Enter Employee ID: ");
            int EmpId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee NAME: ");
            string EmpName = Console.ReadLine();
            Console.Write("Enter Employee SALARY: ");
            double Salary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter kilometre value :");
            int kilo1 = Convert.ToInt32(Console.ReadLine());


            //Creaing Object employee for Employee and after calling method by passing Id and Name
            //For salary value its called directly in Printing

            Employee employee = new Employee();
            employee.SetEmpNo(EmpId);
            employee.SetEmpName(EmpName);
            employee.SetSalary(Salary);
            employee.CalculateSalary();

            //Creaing Object manager for Manager and after calling method by passing Salary 

            Manager manager = new Manager();
            manager.SetSalary(Salary);


            //Creaing Object me for Marketing Executive and after calling methods by passing Salary and Kilometres 

            MarketingExecutive me = new MarketingExecutive();
            me.SetSalary(Salary);
            me.SetKilometersTravel(kilo1);

            Console.WriteLine("Manager Gross Salary is :{0}", manager.SetSalary(Salary));
            Console.WriteLine("MarketingExecutive Gross Salary is :{0}\n", me.SetSalary(Salary));


            //Manager method calling using Delegatemethod 
            Manager.EmployeeDelegate del = new Manager.EmployeeDelegate(manager.CalculateSalary);
            MarketingExecutive.EmployeeDelegate1 del1 = new MarketingExecutive.EmployeeDelegate1(me.CalculateSalary);

            Console.WriteLine("Manager Net Salary is : " + del());
            Console.WriteLine("MarketingExecutive Net Salary is : " + del1());
            Console.ReadKey();
        }
    }
}