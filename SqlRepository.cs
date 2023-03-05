
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll_Service
{
    internal class SqlRepository
    {
        string ConnectionString = @"Data Source=.;Initial Catalog=payroll_service;Integrated Security=True;";
        public List<Employee> GetEmployees()
        {
            string SQL = "select * from empolyee_payroll";
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand(SQL, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Employee> employees = new List<Employee>();
            while (reader.Read())
            {
                var employee = new Employee();
                employee.Id = reader.GetInt32(0);
                employee.EmployeeName = reader.GetString(1);
                employee.Salary = reader.GetInt32(2);
                employee.Date = reader.GetDateTime(3);
                employee.Gender = reader.GetString(4);
                employees.Add(employee);
            }
            connection.Close();
            return employees;
        }
        
    }
}