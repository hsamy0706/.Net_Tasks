using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks.ADOTask.BL.Entities;
using Tasks.ADOTask.DAL;

namespace Tasks.ADOTask.BL.EntityManager
{
    class EmployeeManager
    {
        public static List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new();

            string query = "select * from Employees";

            DBManger.ExcuteQuery(query, 
            reader =>
            {
                Employee emp = new();
                emp.ID = (int)reader["ID"];
                emp.Name = reader["Name"]?.ToString() ?? string.Empty;
                emp.Age = (int)reader["Age"];
                emp.Department= reader["Department"]?.ToString() ?? string.Empty;

                employees.Add(emp);

            });

            return employees;
        }

        public static bool InsertEmployee(Employee emp)
        {
            if (emp == null)
                return false;
            string query = "INSERT INTO Employees (Name, Age, Department) VALUES (@Name, @Age, @Department)";
            SqlParameter[] parameters = new[]
            {
                new SqlParameter("@Name", emp.Name),
                new SqlParameter("@Age", emp.Age),
                new SqlParameter("@Department", emp.Department)
            };

            return DBManger.ExcuteNonQuery(query, parameters) > 0;
        }

        public static bool UpdateDepartment(int employeeId, string newDepartment)
        {
            if (employeeId < 1 || string.IsNullOrEmpty(newDepartment))
                return false;
            string query = "UPDATE Employees SET Department = @Department WHERE ID = @EmployeeID";
            SqlParameter[] parameters = new[]
            {
                new SqlParameter("@Department ", newDepartment),
                new SqlParameter("@EmployeeID", employeeId),
                
            };

            return DBManger.ExcuteNonQuery(query, parameters) > 0;
        }

        public static bool DeleteEmployee(int employeeId)
        {
            if (employeeId < 1)
                return false;

            string query = "DELETE FROM Employees WHERE ID = @EmployeeID";
            SqlParameter[] parameters = new[]
            {
             
                new SqlParameter("@EmployeeID", employeeId),

            };

            return DBManger.ExcuteNonQuery(query, parameters) > 0;


        }


    }
}
