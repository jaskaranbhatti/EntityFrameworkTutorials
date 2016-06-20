using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirstApproach
{
    [Table("tbl_Pragim_Employee_1")]
    public class CodeFirst_Employee
    {
        
        public int Id { get; set; }
        public string FirstName{ get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Salary{ get; set; }

        public int DeptID { get; set; }

        public string JobTitle { get; set; }
    }
}