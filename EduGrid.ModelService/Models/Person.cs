using System;
using System.Collections.Generic;

namespace EduGrid.ModelService.Models
{
    public abstract class Person : BaseModel
    {
        public string Name { get; set; }
        public DateTime Birth { get; set; }
        public string Email { get; set; }

        public List<Phone> Phones { get; set; }
        public Address Address { get; set; }
    }
}
