using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Part17_SelfRefertial_CodeFirst
{
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName{ get; set; }
        public string LastName{ get; set; }
        public string Gender{ get; set; }
        public int Salary{ get; set; }
        public int? ManagerID { get; set; }
        
        //create navigation property
        public Employee Manager { get; set; }


    }
}