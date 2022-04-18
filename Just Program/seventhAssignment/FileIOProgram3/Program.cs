using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace FileIOProgram3
{
    interface IPrintable
    {
        void PrintDetails();
    }
    [Serializable()]
    class Employee : IPrintable
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
        public void PrintDetails()
        {

            Console.WriteLine("Employee No: " + EmpNo + ", Employee Name: " + EmpName + ", Salary: " + Salary);
            Console.WriteLine("HRA: " + this.HRA + ", TA: " + this.TA + ", DA: " + this.DA);
            Console.WriteLine("PF: " + this.PF + ", TDS: " + this.TDS + "\n");
        }

    }

    [Serializable]
    //Inheriting the properties of Employee
    class Manager : Employee
    {
        private double PetrolAllowance;
        private double FoodAllowance;
        private double OtherAllowances;

        public double Gsalary(double Salary)
        {
            base.SetSalary(Salary);
            this.PetrolAllowance = Salary * 8 / 100;
            this.FoodAllowance = Salary * 13 / 100;
            this.OtherAllowances = Salary * 3 / 100;
            return this.GrossSalary = base.GrossSalary + PetrolAllowance + FoodAllowance + OtherAllowances;
        }
        public override double CalculateSalary()
        {
            this.TDS = (this.GrossSalary * 18) / 100;
            NetSalary = GrossSalary - (PF + TDS);
            return NetSalary;
        }

    }
    [Serializable]
    //Inheriting the properties of Employee
    class MarketingExecutive : Employee
    {
        private double KilometerTravel;
        private double TourAllowances;
        private int TelephoneAllowances = 1000;

        //Created a Contructor and passed an argumen
        public void SetKilometersTravel(double Kilo)
        {
            KilometerTravel = Kilo;
            TourAllowances = KilometerTravel * 5;
        }
        public double Gsalary(double Salary)
        {
            base.SetSalary(Salary);
            return GrossSalary += TourAllowances + TelephoneAllowances;
        }
        //Overriding the CalculateSalary() Method of Employee
        public override double CalculateSalary()
        {
            base.SetSalary(Salary);
            this.PF = this.GrossSalary * 10 / 100;
            this.TDS = this.GrossSalary * 18 / 100;
            NetSalary = GrossSalary - (PF + TDS);
            return NetSalary;
        }

    }
    class inheritanceandpolymorphism
    {
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
            employee.PrintDetails();

            Manager manager = new Manager();


            MarketingExecutive me = new MarketingExecutive();


            //the EmployeeInfo.txt file will be created in the bin
            Stream stream = File.Open("EmployeeInfo.txt", FileMode.Create);
            //the ManagerInfo.txt file will be created in the bin

            Stream stream1 = File.Open("ManagerInfo.txt", FileMode.Create);
            //the MarketingExecutiveInfo.txt file will be created in the bin

            Stream stream2 = File.Open("MarketingExecutiveInfo.txt", FileMode.Create);



            //Once a stream is open we create a BinaryFormatter and use the Serialize method to
            //serialize our object to the stream

            BinaryFormatter bformatter = new BinaryFormatter();
            bformatter.Serialize(stream, employee);
            bformatter.Serialize(stream1, manager);
            bformatter.Serialize(stream2, me);



            stream.Close();





            //Creating Object me for Marketing Executive and after calling methods by passing Salary and Kilometres 

            me.SetSalary(Salary);
            me.SetKilometersTravel(kilo1);

            //Display the Gross and Net Salary of Employee and Manager and Marketing Executive
            Console.WriteLine("Employee Gross Salary is : {0}", employee.SetSalary(Salary));
            Console.WriteLine("Employee Net salary is : {0}\n", employee.CalculateSalary());
            Console.WriteLine("Manager Gross Salary is :{0}", manager.Gsalary(Salary));
            Console.WriteLine("Manager Net salary is :{0}\n", manager.CalculateSalary());
            Console.WriteLine("Marketing Executive Gross Salary is :{0}", me.Gsalary(Salary));
            Console.WriteLine("Marketing Executive Net salary is :{0}", me.CalculateSalary());
            Console.ReadKey();
        }
    }
}