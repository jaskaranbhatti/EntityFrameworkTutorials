using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Part19_CodeFirst_TPH_Inheritnce
{
    public partial class EmployeeInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void rbl_EmployeeInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeDBContext _oEmployeeDBContext = new EmployeeDBContext();

            switch(rbl_EmployeeInfo.SelectedValue)
            {
                case "Permanent":
                    gv_EmployeeData.DataSource= _oEmployeeDBContext._oDBSetEmployees.OfType<PermanentEmployee>().ToList();
                    gv_EmployeeData.DataBind();
                    break;
                case "Contractor":
                    gv_EmployeeData.DataSource = _oEmployeeDBContext._oDBSetEmployees.OfType<ContractEmployee>().ToList();
                    gv_EmployeeData.DataBind();
                    break;
                case "AllEmployees":
                    gv_EmployeeData.DataSource = _oEmployeeDBContext._oDBSetEmployees.ToList();
                    gv_EmployeeData.DataBind();
                    break;



            }
        }
    }
}