using Domain.Models.Base;

namespace Domain.Models
{
    public class Visit : BaseEntity
    {
        public string? Date { get; set; }
        public string? VisitorName { get; set; }
        public string PhoneNumber { get; set; }
        public string ClubId { get; set; }
        public Club Club { get; set; }
    }
}
