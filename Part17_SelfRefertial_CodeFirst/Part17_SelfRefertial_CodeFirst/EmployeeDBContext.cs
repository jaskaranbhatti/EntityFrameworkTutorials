using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Part17_SelfRefertial_CodeFirst
{
    public class EmployeeDBContext:DbContext
    {
        public DbSet<Employee> _oEmployeeDBSet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasOptional(e => e.Manager).WithMany().HasForeignKey(m => m.ManagerID);

            base.OnModelCreating(modelBuilder);
        }
    }
}