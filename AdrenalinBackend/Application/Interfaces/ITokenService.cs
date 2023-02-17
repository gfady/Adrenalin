
using Domain.DTOs.Login;
using Domain.Models;

namespace Application.Interfaces
{
    public interface ITokenService
    {
        public string GenerateToken(User user);
    }
}
