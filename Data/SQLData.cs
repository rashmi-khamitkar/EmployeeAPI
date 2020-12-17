using System;
using Microsoft.EntityFrameworkCore;
using EmployeeDepartmentDataAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeDepartmentDataAPI.Data
{
    public class SQLData : IEmployeeDepartment
    {
        private Context _context;
        public SQLData(Context context)
        {
            _context = context;
        }

        public List<EmployeeModel> GetEmployees()
        {
            List<EmployeeModel> employeesList = _context.Employee.FromSqlRaw("EXEC sp_GetEmployeeDepartments ").ToList();
            return employeesList;
        }

        public List<Department> GetDepartments()
        {
            List<Department> departments = _context.Department.FromSqlRaw("select DepartmentID,DepartmentName from Department where Deleted = 0").ToList();
            return departments;
        }
    }
}
