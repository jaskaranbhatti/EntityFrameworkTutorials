using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

using System.Data.Entity;

namespace CodeFirstApproach
{
    public class EmployeeDBContext : DbContext
    {
        public DbSet<CodeFirst_Department> _departmentDBSet { get; set; }
        public DbSet<CodeFirst_Employee> _employeeDBSet { get; set; }

    }
}