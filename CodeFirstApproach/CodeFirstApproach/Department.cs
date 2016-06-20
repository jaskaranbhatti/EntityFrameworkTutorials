using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirstApproach
{
    [Table("tbl_Pragim_Department1")]
    public class CodeFirst_Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public List<CodeFirst_Employee> Employees { get; set; }
    }
}