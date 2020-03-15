using System.Collections.Generic;

namespace EduGrid.ModelService.Models
{
    public class Institute : BaseModel
    {
        public string Name { get; set; }
        public string Initials { get; set; }
        public string Email { get; set; }

        public Address Address { get; set; }
        public List<Phone> Phones { get; set; }

        public List<AcademicCenter> AcademicCenters { get; set; }
    }
}
