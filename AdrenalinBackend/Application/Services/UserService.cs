using Application.Interfaces;
using Domain.DTOs.Login;
using Domain.Interfaces;
using Domain.Models;
using System.Security.Cryptography;
using System.Text;

namespace Application.Services
{
    public class UserService : IUserService
    {
        private readonly ITokenService tokenService;
        private readonly IRepositoryManager manager;

        public UserService(ITokenService tokenService, IRepositoryManager manager)
        {
            this.tokenService = tokenService;
            this.manager = manager;
        }

        public async Task<LoginResponse?> LoginUserAsync(LoginRequest request)
        {
            var user = await manager.User.GetSingleByPropertyAsync(x => x.UserName == request.UserName);

            var hmac = new HMACSHA512(user.PasswordSalt);

            var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(request.Password));

            for (int i = 0; i < computedHash.Length; i++)
            {
                if (computedHash[i] != user.PasswordHash[i]) return null;
            }

            var token = tokenService.GenerateToken(user);

            LoginResponse response = new LoginResponse(user, token);
            return response;
        }

        public async Task<LoginResponse?> RegisterUserAsync(string userName, string password)
        {
            var user = await manager.User.GetSingleByPropertyAsync(x => x.UserName == userName);// check if userName is unique

            if (user != null) return null;

            var hmac = new HMACSHA512();

            var newUser = new User() { Id = Guid.NewGuid().ToString(), UserName = userName, Role="admin" };

            newUser.PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            newUser.PasswordSalt = hmac.Key;

            await manager.User.AddAsync(newUser);
            await manager.CommitAsync();

            var token = tokenService.GenerateToken(newUser);

            LoginResponse response = new LoginResponse(newUser, token);
            return response;
        }

        public async Task<bool> GetUserByName(string userName)
        {
            var user = await manager.User.GetSingleByPropertyAsync(x => x.UserName == userName);
            return user != null? true: false;
        } 
    }
}
