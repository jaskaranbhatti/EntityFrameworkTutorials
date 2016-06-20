using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Part11_EntitySplitting_CodeFirst
{
    public class EmployeeRepository
    {
        EmployeeDBContext _oEmpDBContextClass = new EmployeeDBContext();

        public List<Employee> GetAllEmployees()
        {
            return _oEmpDBContextClass._oDBSetEmployees.ToList();
        }

        public void InsertNewEmployeeRecord(Employee _oNewEmployee)
        {
            _oEmpDBContextClass._oDBSetEmployees.Add(_oNewEmployee);
            _oEmpDBContextClass.SaveChanges();
        }

        public void DeleteEmployeeRecord(Employee _oEmpToBeDeleted)
        {
            _oEmpDBContextClass._oDBSetEmployees.Remove(_oEmpToBeDeleted);
            _oEmpDBContextClass.SaveChanges();
        }

        public void UpdateEmployeeRecord(Employee _oEmpToBeUpdated)
        {
            Employee _oTempEmpData = _oEmpDBContextClass._oDBSetEmployees.FirstOrDefault(x=>x.EmployeeID==_oEmpToBeUpdated.EmployeeID);
            _oTempEmpData.FirstName = _oEmpToBeUpdated.FirstName;
            _oTempEmpData.LastName= _oEmpToBeUpdated.LastName;
            _oTempEmpData.Gender = _oEmpToBeUpdated.Gender;
            _oTempEmpData.PhoneNumber= _oEmpToBeUpdated.PhoneNumber;
            _oTempEmpData.Address= _oEmpToBeUpdated.Address;
            _oTempEmpData.EmailID = _oEmpToBeUpdated.EmailID;

            _oEmpDBContextClass.SaveChanges();
        }




    }
}