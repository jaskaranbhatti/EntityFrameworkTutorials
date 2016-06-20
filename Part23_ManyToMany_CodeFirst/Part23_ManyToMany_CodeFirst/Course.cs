using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Part23_ManyToMany_CodeFirst
{
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public ICollection<Student> _oICollStudents { get; set; }
    }
}