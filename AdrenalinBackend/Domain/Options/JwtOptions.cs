using System.Text;

namespace Domain.Options
{
    public class JwtOptions
    {
        readonly static string JWTSecretKey = "bRhYJRlZvBj2vW4MrV5HVdPgIE6VMtCFB0kTtJ1m";
        public static readonly int JWTLifespan = 2592000;
        public static byte[] GenerateBytes() => Encoding.ASCII.GetBytes(JWTSecretKey);
    }
}
