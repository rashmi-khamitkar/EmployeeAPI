using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeDepartmentDataAPI.Models
{
    public class EmployeeModel
    {
        [Key]
        public int EmployeeID { get; set; }
        public string SubDepartmentName { get; set; }
        public string DepartmentName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Bio { get; set; }
        public string ProfileImage { get; set; }
        public string FBProfileLink { get; set; }
        public string TwitterProfileLink { get; set; }
    }
}
