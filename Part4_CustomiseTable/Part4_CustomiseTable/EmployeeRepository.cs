using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Part4_CustomiseTable
{
    public class EmployeeRepository
    {
        public List<Department> GetAllDepartments()
        {
            EmployeeContext _oEmployeeDBContext = new EmployeeContext();
            return _oEmployeeDBContext._dbSetDepartment.ToList();
        }
    }
}