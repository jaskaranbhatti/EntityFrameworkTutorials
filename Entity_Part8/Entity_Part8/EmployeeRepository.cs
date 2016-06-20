using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity_Part8
{
    public class EmployeeRepository
    {
        EmployeeDBContext _oEmployeeDBContext = new EmployeeDBContext();

        public List<tbl_Pragim_Employee_1> GetAllEmployees()
        {
            return _oEmployeeDBContext._dbSetEmployees.ToList();
        }

        public void InsertNewEmployee(tbl_Pragim_Employee_1 _oEmployee)
        {
            _oEmployeeDBContext._dbSetEmployees.Add(_oEmployee);
            _oEmployeeDBContext.SaveChanges();
        }

        public void UpdateEmployeeRecord(tbl_Pragim_Employee_1 _oEmployee)
        {
            tbl_Pragim_Employee_1 _oUpdateEmployee= _oEmployeeDBContext._dbSetEmployees.FirstOrDefault(x => x.Id == _oEmployee.Id);

            _oUpdateEmployee.FirstName = _oEmployee.FirstName;
            _oUpdateEmployee.LastName = _oEmployee.LastName;
            _oUpdateEmployee.Gender= _oEmployee.Gender;
            _oUpdateEmployee.Salary = _oEmployee.Salary;
            _oUpdateEmployee.JobTitle = _oEmployee.JobTitle;

            _oEmployeeDBContext.SaveChanges();
        }

        public void DeleteEmployeeRecord(tbl_Pragim_Employee_1 _oEmployee)
        {
            tbl_Pragim_Employee_1 _oDeleteEmployee = _oEmployeeDBContext._dbSetEmployees.FirstOrDefault(x => x.Id == _oEmployee.Id);

            _oEmployeeDBContext._dbSetEmployees.Remove(_oDeleteEmployee);
            _oEmployeeDBContext.SaveChanges();
        }


    }
}