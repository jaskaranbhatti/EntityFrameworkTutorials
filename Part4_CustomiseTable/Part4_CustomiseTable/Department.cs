using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Part4_CustomiseTable
{
    [Table("tbl_Pragim_Department")]
    public class Department
    {
        [Column("DepartmentID")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set;  }
        public List<Employee> ListOfEmployees { get; set; }
    }

}