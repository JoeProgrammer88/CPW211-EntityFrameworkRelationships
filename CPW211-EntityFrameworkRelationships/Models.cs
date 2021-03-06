using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_EntityFrameworkRelationships
{
    public class Student
    {
        [Key] // PK
        public int StudentId { get; set; }

        public string FullName { get; set; } = null!;

        public List<Course>? Courses { get; set; }

        [ForeignKey(nameof(AssignedAdvisor))] // FK
        public int? AssignedAdvisorId { get; set; }

        public Advisor? AssignedAdvisor { get; set; }
    }

    public class Advisor
    {
        [Key]
        public int AdvisorId { get; set; }

        public string Email { get; set; } = null!;

        public List<Student>? AssignedStudent { get; set; }
    }

    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        public string Title { get; set; } = null!;

        public List<Student>? Students { get; set; }
    }
}
