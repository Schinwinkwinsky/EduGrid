using System;

namespace EduGrid.ModelService.Models
{
    public class BaseModel
    {
        public Guid Id { get; set; }

        // Auditoria
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }

        public Guid CreatedBy { get; set; }
        public Guid UpdatedBy { get; set; }
        public Guid DeletedBy { get; set; }

        public bool IsActive => DeletedAt == DateTime.MinValue;
    }
}
