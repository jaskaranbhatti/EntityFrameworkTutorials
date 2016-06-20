using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Part11_EntitySplitting_CodeFirst
{
    public class Employee
    {
        public int EmployeeID { get; set; }

        //properties related to Emp Table
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender{ get; set; }
        
        //properties related to EmpContacts Table
        public string EmailID { get;  set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }


    }
}