using System;
namespace EmployeeDepartmentDataAPI.Models
{
    public class SubDepartment
    {
        public int SubDepartmentID { get; set; }
        public Department Department { get; set; }
        public string SubDepartmentName { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool Deleted { get; set; }
        public DateTime DeletedDate { get; set; }
    }
}
