using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Part23_ManyToMany_CodeFirst
{
    public partial class StudentCourseDetails1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EmployeeDBContext _oEmployeeDBContext = new EmployeeDBContext();
            GridView1.DataSource = (from student in _oEmployeeDBContext._oStudentDBSet
                                   from course in _oEmployeeDBContext._oCourseDBSet
                                   select new
                                   {
                                       StudentName = student.StudentName,
                                       CourseName = course.CourseName
                                   }).ToList();
            GridView1.DataBind();

        }
    }
}