using System;
using System.Collections.Generic;

namespace EduGrid.ModelService.Models
{
    public class Course : BaseModel
    {
        public string Name { get; set; }
        public List<Subject> Subjects { get; set; }

        public List<Student> Students { get; set; }

        public Guid CoordinatorId { get; set; }
        public Coordinator Coordinator { get; set; }

        public Guid AcademicCenterId { get; set; }
        public AcademicCenter AcademicCenter { get; set; }
    }
}
