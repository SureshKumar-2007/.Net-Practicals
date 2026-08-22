using System;

namespace Practical1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();

            student1.CaptureStudentDetails();
            student1.CalculateScholarship();
            student1.PrintStudentDetails();

            Console.ReadKey();
        }
    }
    class Student
    {
        public int GrNo;
        public string Name;
        public string Course;
        public int Sem;

        private double Fee;
        private bool Eligible;

        private double ScholarshipRate = 0.10;   
        private double ScholarshipLimit = 50000; 
        public Student()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("     Student Management System"         );
            Console.WriteLine("---------------------------------------");
        }
        public void CaptureStudentDetails()
        {
            Console.Write("Enter GR No      : ");
            GrNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name       : ");
            Name = Console.ReadLine();

            Console.Write("Enter Course     : ");
            Course = Console.ReadLine();

            Console.Write("Enter Semester   : ");
            Sem = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Fee        : ");
            Fee = Convert.ToDouble(Console.ReadLine());
        }
        public void CalculateScholarship()
        {
            if (Fee <= ScholarshipLimit)
            {
                Eligible = true;
            }
            else
            {
                Eligible = false;
            }
        }
        public void PrintStudentDetails()
        {
            Console.WriteLine("\n---------------------------------------");
            Console.WriteLine("GR No              : " + GrNo);
            Console.WriteLine("Name               : " + Name);
            Console.WriteLine("Course             : " + Course);
            Console.WriteLine("Semester           : " + Sem);
            Console.WriteLine("Fee                : " + Fee);
            Console.WriteLine("Eligible           : " + Eligible);
            Console.WriteLine("Scholarship Limit  : " + ScholarshipLimit);
            Console.WriteLine("Scholarship Rate   : 10%");

            if (Eligible)
            {
                double FinalFee = Fee - (Fee * ScholarshipRate);
                Console.WriteLine("Final Fee          : " + FinalFee);
            }
            else
            {
                Console.WriteLine("Final Fee          : " + Fee);
            }
        }
    }
}