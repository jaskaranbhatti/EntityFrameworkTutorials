using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Part23_ManyToMany_CodeFirst
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public ICollection<Course> _oICollCourses { get; set; }

    }
}
