using Application.Interfaces;
using Domain.Models;
using Domain.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Application.Services
{
    public class TokenService : ITokenService
    {
        public string GenerateToken(User user)
        {
            var expirationTime = DateTime.UtcNow.AddSeconds(JwtOptions.JWTLifespan);

            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(JwtOptions.GenerateBytes()),
                    SecurityAlgorithms.HmacSha256Signature),

                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim("id", user.Id),
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(ClaimTypes.Role, user.Role)
                }),

                Expires = expirationTime,
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);//Serializes a System.IdentityModel.Tokens.Jwt.JwtSecurityToken into a JWT in Compact Serialization Format.
        }
    }
}
