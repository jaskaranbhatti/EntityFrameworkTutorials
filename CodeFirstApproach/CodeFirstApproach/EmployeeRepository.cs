 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstApproach
{
    public class EmployeeRepository
    {

        public List<CodeFirst_Department> GetAllDepartments()
        {
            EmployeeDBContext _oEmployeeDBContext = new EmployeeDBContext();
            return _oEmployeeDBContext._departmentDBSet.Include("Employees").ToList();
        }



    }
}