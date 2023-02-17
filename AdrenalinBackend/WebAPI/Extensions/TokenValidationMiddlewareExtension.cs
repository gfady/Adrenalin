using WebAPI.Middleware;

namespace WebAPI.Extensions
{
    public static class TokenValidationMiddlewareExtension
    {
        public static IApplicationBuilder UseTokenValidationMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<TokenValidationMiddleware>();
        }
    }
}
