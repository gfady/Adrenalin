using Domain.Models.Base;

namespace Domain.Models
{
    public class Club : BaseEntity
    {
        public string? Image { get; set; }
        public string? City { get; set; }
        public string? Adress { get; set; }

        public List<Visit> Visits { get; set; }
    }
}
