using System;
using System.Collections.Generic;

namespace Practical3
{
    class Expense
    {
        public int ExpenseId;
        public string Category;
        public double Amount;
        public string PaymentMode;
        public DateTime ExpenseDate;
        public void AddExpense()
        {
            Console.Write("Enter Expense ID: ");
            ExpenseId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Category: ");
            Category = Console.ReadLine();

            Console.Write("Enter Amount: ");
            Amount = Convert.ToDouble(Console.ReadLine());

            if (Amount <= 0)
            {
                throw new Exception("Amount must be greater than 0.");
            }

            Console.Write("Enter Payment Mode: ");
            PaymentMode = Console.ReadLine();

            Console.Write("Enter Expense Date (dd/mm/yyyy): ");
            ExpenseDate = Convert.ToDateTime(Console.ReadLine());
        }
        public void DisplayExpense()
        {
            Console.WriteLine("\n----- Expense Details -----");
            Console.WriteLine("Expense ID   : " + ExpenseId);
            Console.WriteLine("Category     : " + Category);
            Console.WriteLine("Amount       : " + Amount);
            Console.WriteLine("Payment Mode : " + PaymentMode);
            Console.WriteLine("Expense Date : " + ExpenseDate.ToShortDateString());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Expense> expenses = new List<Expense>();
            int choice;

            do
            {
                Console.WriteLine("\n===== Expense Tracking System =====");
                Console.WriteLine("1. Add Expense");
                Console.WriteLine("2. View All Expenses");
                Console.WriteLine("3. Exit");

                Console.Write("Enter Your Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                try
                {
                    switch (choice)
                    {
                        case 1:
                            Expense e = new Expense();
                            e.AddExpense();
                            expenses.Add(e);
                            Console.WriteLine("Expense Added Successfully.");
                            break;

                        case 2:
                            if (expenses.Count == 0)
                            {
                                Console.WriteLine("No Expense Found.");
                            }
                            else
                            {
                                foreach (Expense exp in expenses)
                                {
                                    exp.DisplayExpense();
                                }
                            }
                            break;

                        case 3:
                            Console.WriteLine("Thank You!");
                            break;

                        default:
                            Console.WriteLine("Invalid Choice.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }

            } while (choice != 3);

            Console.ReadKey();
        }
    }
}