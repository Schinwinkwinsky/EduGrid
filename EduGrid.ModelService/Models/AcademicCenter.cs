using System;
using System.Collections.Generic;

namespace EduGrid.ModelService.Models
{
    public class AcademicCenter : BaseModel
    {
        public string Name { get; set; }
        public string Initials { get; set; }
        public List<Course> Courses { get; set; }

        public Guid CoordinatorId { get; set; }
        public Coordinator Coordinator { get; set; }

        public Guid InstituteId { get; set; }
        public Institute Institute { get; set; }
    }
}
