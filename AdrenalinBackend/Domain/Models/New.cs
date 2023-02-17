using Domain.Models.Base;

namespace Domain.Models
{
    public class New : BaseEntity
    {
        public DateOnly Date { get; set; }
        public string? Image { get; set; }
        public string? Title { get; set; }
        public string? Text { get; set; }
    }
}
