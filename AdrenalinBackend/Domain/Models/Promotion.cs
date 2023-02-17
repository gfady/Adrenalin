using Domain.Models.Base;

namespace Domain.Models
{
    public class Promotion : BaseEntity
    {
        public string? Image { get; set; }
        public string? Title { get; set; }
        public string? Text { get; set; }
    }
}
