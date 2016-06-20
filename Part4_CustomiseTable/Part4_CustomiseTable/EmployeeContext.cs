using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Part4_CustomiseTable
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> _dbSetEmployees { get; set; }
        public DbSet<Department> _dbSetDepartment { get; set; }
    }
}