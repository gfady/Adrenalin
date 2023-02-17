
using Domain.Models;

namespace Domain.DTOs.Login
{
    public class LoginResponse
    {
        public string? Id { get; set; }
        public string? UserName { get; set; }
        public string? Role { get; set; }
        public string? Token { get; set; }

        public LoginResponse(User user, string token)
        {
            Id = user.Id;
            UserName = user.UserName;
            Role = user.Role;
            Token = token;
        }
    }
}
