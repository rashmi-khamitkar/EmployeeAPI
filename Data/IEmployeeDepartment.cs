using System;
using System.Collections.Generic;
using EmployeeDepartmentDataAPI.Models;

namespace EmployeeDepartmentDataAPI.Data
{
    public interface IEmployeeDepartment
    {
        List<EmployeeModel> GetEmployees();
        List<Department> GetDepartments();
    }
}
