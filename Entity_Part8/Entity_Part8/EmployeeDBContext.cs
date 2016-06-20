using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Entity_Part8
{
    public class EmployeeDBContext : DbContext
    {
        public DbSet<tbl_Pragim_Employee_1> _dbSetEmployees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbl_Pragim_Employee_1>().MapToStoredProcedures
                
                (
                            p => p.Insert(
                                    i => i.HasName("usp_Pragim_InsertEmployee")
                                        .Parameter(n => n.FirstName, "EmpFirstName")
                                        .Parameter(n => n.LastName, "EmpLastName")
                                        .Parameter(n => n.Gender, "EmpGender")
                                        .Parameter(n => n.Salary, "EmpSalary")
                                        .Parameter(n => n.JobTitle, "EmpJobTitle")
                                 )
                              .Update
                              (
                                    u => u.HasName("usp_Pragim_UpdateEmployee")
                                        .Parameter(n => n.Id, "EmpID")
                                        .Parameter(n => n.FirstName, "EmpFirstName")
                                        .Parameter(n => n.LastName, "EmpLastName")
                                        .Parameter(n => n.Gender, "EmpGender")
                                        .Parameter(n => n.Salary, "EmpSalary")
                                        .Parameter(n => n.JobTitle, "EmpJobTitle")
                            )
                            .Delete
                            (
                                    d => d.HasName("usp_Pragim_DeleteEmployee")
                                        .Parameter(n => n.Id, "EmpID")

                            )


                 

                );


            base.OnModelCreating(modelBuilder);
        }

    }
}