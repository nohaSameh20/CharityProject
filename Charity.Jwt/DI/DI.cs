using Charity.Application.Users.Auth;
using CharityProject.Common.IService;
using CharityProject.JWT;
using CharityProject.JWT.Core;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Charity.Jwt.DI
{
    public static class DI
    {
        public static void RegisterJWT(this IServiceCollection service, JWTConfigurationModel JwtSection)
        {
            service.AddScoped<ICurrentUser, CurrentUser>();
            service.AddScoped<IJWTService>(provider => new JWTService(JwtSection));


            var key = Encoding.ASCII.GetBytes(JwtSection.Secret);
            service.AddAuthentication(option =>
            {
                option.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(option =>
            {
                option.RequireHttpsMetadata = false;
                option.SaveToken = true;
                option.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                };
            });
        }
    }
}
