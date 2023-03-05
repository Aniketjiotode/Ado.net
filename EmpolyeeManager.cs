
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll_Service
{
    internal class EmployeeManager
    {
        private readonly SqlRepository repo;
        public EmployeeManager(SqlRepository repo)
        {
            this.repo = repo;
        }
        public void GetEmployees()
        {
            var employees = repo.GetEmployees();
            if (employees.Count <= 0)
            {
                Console.WriteLine($"list is empty");
            }
            else
            {
                foreach (var item in employees)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }
    }
}