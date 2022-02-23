using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_EntityFrameworkRelationships
{
    public class Student
    {
        public int StudentId { get; set; }

        public string FullName { get; set; } = null!;

        public List<Course> Courses { get; set; }
    }

    public class Course
    {
        public int CourseId { get; set; }

        public string Title { get; set; } = null!;

        public List<Student> Students { get; set; }
    }
}
