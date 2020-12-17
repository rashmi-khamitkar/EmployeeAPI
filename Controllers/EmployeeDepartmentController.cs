using Microsoft.AspNetCore.Mvc;
using EmployeeDepartmentDataAPI.Models;
using EmployeeDepartmentDataAPI.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeDepartmentDataAPI.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeDepartmentController : ControllerBase
    {
        private IEmployeeDepartment _employeeDepartment;
        public EmployeeDepartmentController(IEmployeeDepartment employeeDepartment)
        {
            _employeeDepartment = employeeDepartment;
        }

        [HttpGet]
        public IActionResult GetEmployees()
        {
            return Ok(_employeeDepartment.GetEmployees());
        }

        [HttpGet]
        [Route("department")]
        public IActionResult GetDepartments()
        {
            return Ok(_employeeDepartment.GetDepartments());
        }
    }
}
