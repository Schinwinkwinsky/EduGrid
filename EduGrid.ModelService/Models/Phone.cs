namespace EduGrid.ModelService.Models
{
    public class Phone : BaseModel
    {
        public string DDI { get; set; }
        public string DDD { get; set; }
        public string Number { get; set; }

        public PhoneType PhoneType { get; set; }
    }

    public enum PhoneType
    {
        Home, Comercial, Mobile
    }
}
