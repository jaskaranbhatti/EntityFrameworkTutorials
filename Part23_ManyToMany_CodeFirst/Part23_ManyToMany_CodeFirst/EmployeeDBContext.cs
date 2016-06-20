using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Part23_ManyToMany_CodeFirst
{
    public class EmployeeDBContext:DbContext
    {
        public DbSet<Student> _oStudentDBSet { get; set; }
        public DbSet<Course> _oCourseDBSet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasMany(t => t._oICollCourses)
                .WithMany(t => t._oICollStudents)
                .Map(m =>
                    {
                        m.ToTable("StudentCourses");
                        m.MapLeftKey("StudentID");
                        m.MapRightKey("CourseID");
                    });


            base.OnModelCreating(modelBuilder);
        }
    }

    
}