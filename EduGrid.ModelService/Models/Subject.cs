using System;
using System.Collections.Generic;

namespace EduGrid.ModelService.Models
{
    public class Subject : BaseModel
    {
        public string Name { get; set; }

        public List<Guid> RequiredSubjects { get; set; }
        public List<Guid> RequiresSubjects { get; set; }

        public Guid CourseId { get; set; }
        public Course Course { get; set; }
    }
}
