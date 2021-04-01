using Charity.Application.Users.Auth;
using CharityProject.JWT.Core;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
namespace CharityProject.JWT
{
    public class JWTService : IJWTService
    {
        private readonly JWTConfigurationModel configuration;

        public JWTService(JWTConfigurationModel configuration)
        {
            this.configuration = configuration;
        }
        public string GenerateAccessToken(List<Claim> claims, DateTime expireAt)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var Key = Encoding.ASCII.GetBytes(configuration.Secret);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Key), SecurityAlgorithms.HmacSha256Signature),
                Expires = expireAt
            };

            var securityToken = tokenHandler.CreateToken(tokenDescriptor);
            var token = tokenHandler.WriteToken(securityToken);

            return token;
        }

        public string GenerateRefreshToken()
        {
            var randomNumber = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
                return Convert.ToBase64String(randomNumber);
            }
        }
    }
}
