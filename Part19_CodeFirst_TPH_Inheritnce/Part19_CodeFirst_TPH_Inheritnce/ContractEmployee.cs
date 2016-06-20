using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Part19_CodeFirst_TPH_Inheritnce
{
    public class ContractEmployee:Employee
    {
        public int HoursWorked { get; set; }
        public int HoursPay { get; set; }
    }
}