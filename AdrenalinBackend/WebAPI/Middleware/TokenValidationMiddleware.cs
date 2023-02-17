using Domain.Interfaces;
using Domain.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;

namespace WebAPI.Middleware
{
    public class TokenValidationMiddleware
    {
        private readonly RequestDelegate next;
        public TokenValidationMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context, IRepositoryManager manager)
        {
            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

            if (token != null)
            {
                await ValidateAndAttach(context, token, manager);
            }

            await next(context);
        }

        private async Task ValidateAndAttach(HttpContext context, string token, IRepositoryManager manager)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = JwtOptions.GenerateBytes();

                tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ClockSkew = TimeSpan.Zero,
                    ValidateIssuerSigningKey = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                }, out SecurityToken validated);

                var jwtToken = (JwtSecurityToken)validated;

                string id = jwtToken.Claims.FirstOrDefault(x => x.Type.Equals("id")).Value;

                context.Items["User"] = await manager.User.GetSingleAsync(id);
            }

            catch { }
        }
    }
}
