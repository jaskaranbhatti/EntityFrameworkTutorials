using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Part15_CodeFirstConditionalMapping
{
    public partial class DisplayDeptDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            EmployeeDBContext _oEmployeeDBContext = new EmployeeDBContext();
            GridView1.DataSource = _oEmployeeDBContext._oDBSetEmployees.ToList();
            GridView1.DataBind();

        }
    }
}