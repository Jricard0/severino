using System;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Severino.Helpers
{
    public class JWTHelper
    {
        private static byte[] SIGNING_KEY = Encoding.UTF8.GetBytes(Environment.GetEnvironmentVariable("SEVERINO_JWT_SIGNING_KEY"));

        public static string Generate(ClaimsIdentity claims, DateTime tokenExpirationDate)
        {
            var handler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new Microsoft.IdentityModel.Tokens.SecurityTokenDescriptor()
            {
                Subject = claims,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(SIGNING_KEY), SecurityAlgorithms.HmacSha256Signature),
                IssuedAt = DateTime.Now,
                Expires = tokenExpirationDate
            };

            var token = handler.CreateEncodedJwt(tokenDescriptor);
            return token;
        }

        public static async Task<bool> ValidateToken(string token)
        {
            if (string.IsNullOrWhiteSpace(token))
                throw new Exception("Token must be provided.");

            var handler = new JwtSecurityTokenHandler();
            var validationParameters = new TokenValidationParameters()
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(SIGNING_KEY),
                ValidateIssuer = false,
                ValidateAudience = false,
                ClockSkew = TimeSpan.Zero
            };

            var validatedToken = await handler.ValidateTokenAsync(token, validationParameters);

            return validatedToken.IsValid;
        }

        public static async Task<TokenValidationResult> DecodeToken(string token)
        {
            var handler = new JwtSecurityTokenHandler();
            var validationParameters = new TokenValidationParameters()
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(SIGNING_KEY),
                ValidateIssuer = false,
                ValidateAudience = false,
                ClockSkew = TimeSpan.Zero
            };

            var validatedToken = await handler.ValidateTokenAsync(token, validationParameters);

            return validatedToken;
        }
    }
}
