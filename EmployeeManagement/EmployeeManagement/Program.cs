using System;

namespace ConsoleApp1
{
    interface ISalary
    {
        void CalculateSalary();
    }
    class Employee : ISalary
    {
        public int EmployeeId;
        public string EmployeeName;
        public double EmployeeSalary;

        public Employee()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("      Employee Details");
            Console.WriteLine("-------------------------------");
        }

        public void AcceptDetails()
        {
            Console.Write("Enter Employee Id     : ");
            EmployeeId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee Name   : ");
            EmployeeName = Console.ReadLine();

            Console.Write("Enter Employee Salary : ");
            EmployeeSalary = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayDetails()
        {
            Console.WriteLine("\nEmployee Id      : " + EmployeeId);
            Console.WriteLine("Employee Name    : " + EmployeeName);
            Console.WriteLine("Employee Salary  : " + EmployeeSalary);
        }

        public virtual void CalculateSalary()
        {
            Console.WriteLine("Salary : " + EmployeeSalary);
        }
    }
    class FullTimeEmployee : Employee
    {
        public override void CalculateSalary()
        {
            double HRA = EmployeeSalary * 0.20;
            double DA = EmployeeSalary * 0.10;
            double TotalSalary = EmployeeSalary + HRA + DA;

            Console.WriteLine("HRA          : " + HRA);
            Console.WriteLine("DA           : " + DA);
            Console.WriteLine("Total Salary : " + TotalSalary);
        }
    }
    class PartTimeEmployee : Employee
    {
        public override void CalculateSalary()
        {
            double Bonus = EmployeeSalary * 0.05;
            double TotalSalary = EmployeeSalary + Bonus;

            Console.WriteLine("Bonus        : " + Bonus);
            Console.WriteLine("Total Salary : " + TotalSalary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp;

            Console.WriteLine("1. Full Time Employee");
            Console.WriteLine("2. Part Time Employee");

            Console.Write("Enter Your Choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                emp = new FullTimeEmployee();
            }
            else if (choice == 2)
            {
                emp = new PartTimeEmployee();
            }
            else
            {
                Console.WriteLine("Invalid Choice");
                return;
            }

            emp.AcceptDetails();
            emp.DisplayDetails();
            emp.CalculateSalary();

            Console.ReadKey();
        }
    }
}