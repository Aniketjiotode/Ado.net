using System;

namespace PayRoll_Service
{
        internal class Program
        {
            public static void Main()
            {
                while (true)
                {
                    Console.WriteLine("Enter 1 to get all Employees");
                    int input = int.Parse(Console.ReadLine());
                    EmployeeManager manager = new EmployeeManager(new SqlRepository());
                    switch (input)
                    {
                        case 1: manager.GetEmployees(); break;
               
                        default: Console.WriteLine("Invalid Entry"); break;
                    }
                }
            }
        }
        public class Employee
        {
            public int Id { get; set; }
            public string EmployeeName { get; set; }
            public decimal Salary { get; set; }
            public DateTime Date { get; set; }
            public string Gender { get; set; }
            public override string ToString()
            {
                var st = $"ID: {Id}\nName: {EmployeeName}\nSalary: {Salary}\nDate: {Date}\nGender: {Gender}  \n-----------------\n";
                return st;
            }
        }   
}
