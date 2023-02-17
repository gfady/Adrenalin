using Domain.Models.Base;

namespace Domain.Models
{
    public class User: BaseEntity
    {
        public string? UserName { get; set; }
        public byte[]? PasswordHash { get; set; }
        public byte[]? PasswordSalt { get; set; }
        public string? Role { get; set; }
    }
}
