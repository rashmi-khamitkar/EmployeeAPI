using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeDepartmentDataAPI.Models
{
    public class Department
    {
        [Key]
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        //public DateTime AddedDate { get; set; }
        //public DateTime UpdatedDate { get; set; }
        //public bool Deleted { get; set; }
        //public DateTime DeletedDate { get; set; }
    }
}
