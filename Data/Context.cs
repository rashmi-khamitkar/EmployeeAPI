using System;
using Microsoft.EntityFrameworkCore;
using EmployeeDepartmentDataAPI.Models;

namespace EmployeeDepartmentDataAPI.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<EmployeeModel> Employee { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<SubDepartment> subDepartment { get; set; }
    }
}
