using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Part19_CodeFirst_TPH_Inheritnce
{
    public class EmployeeDBContext:DbContext
    {
        public DbSet<Employee> _oDBSetEmployees { get; set; }
    }
}