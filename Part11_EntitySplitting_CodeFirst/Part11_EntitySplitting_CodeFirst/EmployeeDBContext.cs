using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Part11_EntitySplitting_CodeFirst
{
    public class EmployeeDBContext:DbContext
    {
        public DbSet<Employee> _oDBSetEmployees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Map(map =>
                {
                    map.Properties(p => new
                    {
                        p.EmployeeID,
                        p.FirstName,
                        p.LastName,
                        p.Gender
                    });
                    map.ToTable("tbl_Employees");
                })
                .Map(map =>
                {
                    map.Properties(p => new
                    {
                        p.EmployeeID,
                        p.Address,
                        p.EmailID,
                        p.PhoneNumber
                    });
                    map.ToTable("tbl_EmployeeContactDetails");
                });
            base.OnModelCreating(modelBuilder);
        }
    }
}