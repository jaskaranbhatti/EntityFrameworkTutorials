using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Part15_CodeFirstConditionalMapping
{
    [Table("tbl_Employee_TerminateInfo")]
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName{ get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public bool isTerminated{ get; set; }
    }
}