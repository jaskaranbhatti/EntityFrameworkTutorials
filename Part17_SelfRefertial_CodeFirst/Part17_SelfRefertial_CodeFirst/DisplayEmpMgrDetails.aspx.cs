using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Part17_SelfRefertial_CodeFirst
{
    public partial class DisplayEmpMgrDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            EmployeeDBContext _oEmployeeDBContext = new EmployeeDBContext();
            GridView1.DataSource = _oEmployeeDBContext._oEmployeeDBSet.Select(emp => new
            {
                FirstName=emp.FirstName,
                Manager=emp.Manager ==null ?"Super Boss" :emp.Manager.FirstName
            }).ToList();
            GridView1.DataBind();
                

        }
    }
}