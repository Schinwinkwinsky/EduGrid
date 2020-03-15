using System;

namespace EduGrid.ModelService.Models
{
    public class Student : Person
    {
        public DateTime DateOfEntry { get; set; }

        public Guid CourseId { get; set; }
        public Course Course { get; set; }
    }
}
