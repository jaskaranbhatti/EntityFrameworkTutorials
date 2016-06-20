using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstApproach
{
    public class EmployeeDBContextSeeder : DropCreateDatabaseIfModelChanges<EmployeeDBContext>
    {
        protected override void Seed(EmployeeDBContext context)
        {
            CodeFirst_Department _oDepartment1 = new CodeFirst_Department()
            {
                Name = "IT",
                Location = "Tampa",
                Employees = new List<CodeFirst_Employee>()
                {
                    new CodeFirst_Employee()
                    {
                        FirstName="Amitabh", LastName="Bachan", Gender="Male", JobTitle="Software Engineer",
                        Salary=60000
                    },
                    new CodeFirst_Employee()
                    {
                        FirstName="Brian",LastName="Mounger", Gender="Male", JobTitle="Project Manager",
                        Salary=80000

                    }
                }

            };
            CodeFirst_Department _oDepartment2 = new CodeFirst_Department()
            {
                Name = "Computer Hardware",
                Location = "Baltimore",
                Employees = new List<CodeFirst_Employee>()
                {
                    new CodeFirst_Employee()
                    {
                        FirstName="Patrick",LastName="Johnson", Gender="Male", JobTitle="Associate Hardware Engineer",
                        Salary=40000 

                    }
                }

            };




            context._departmentDBSet.Add(_oDepartment1);
            context._departmentDBSet.Add(_oDepartment2);
            base.Seed(context);
        }

    }
}