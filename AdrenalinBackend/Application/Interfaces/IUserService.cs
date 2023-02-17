using Domain.DTOs.Login;
using Domain.Models;

namespace Application.Interfaces
{
    public interface IUserService
    {
        Task<LoginResponse?> RegisterUserAsync(string userName, string password);
        Task<LoginResponse?> LoginUserAsync(LoginRequest request);
        Task<bool> GetUserByName(string userName);
    }
}
