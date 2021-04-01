using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace Charity.Application.Users.Auth
{
    public interface IJWTService
    {
        string GenerateAccessToken(List<Claim> claims, DateTime expireAt);
        string GenerateRefreshToken();
    }
}
