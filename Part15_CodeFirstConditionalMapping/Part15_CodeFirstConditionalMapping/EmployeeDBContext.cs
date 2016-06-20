using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Part15_CodeFirstConditionalMapping
{
    public class EmployeeDBContext : DbContext
    {
        public DbSet<Employee> _oDBSetEmployees { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Map(m => m.Requires("isTerminated").HasValue(true))
                .Ignore(m => m.isTerminated);

            base.OnModelCreating(modelBuilder);
                
        }
    }
}