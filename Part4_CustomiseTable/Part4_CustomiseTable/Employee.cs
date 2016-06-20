using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Part4_CustomiseTable
{
    [Table("tbl_Pragim_Employee")]
    public class Employee
    {
        [Column("EmployeeID")]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender{ get; set; }
        public int Salary { get; set; }

        public int DepartmentID { get; set; }
        [ForeignKey("DepartmentID")]
        public Department Department { get; set; }



    }
}