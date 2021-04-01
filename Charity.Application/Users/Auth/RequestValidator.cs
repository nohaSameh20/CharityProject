using CharityProject.Application.Interfaces;
using CharityProject.Common;
using CharityProject.Common.IService;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Charity.Application.Users.Auth
{
    public class RequestValidator
    {
        private readonly RequestDelegate _next;
        private IHttpContextAccessor httpContextAccessor;
        byte[] outToBytes;
        string UserId;
        public RequestValidator(RequestDelegate next,IHttpContextAccessor httpContextAccessor)
        {
            _next = next;
            this.httpContextAccessor = httpContextAccessor;
        }

        public async Task Invoke(HttpContext context)
        {
            
            var user = httpContextAccessor.HttpContext.Session.TryGetValue("UserId", out outToBytes).ToString();
            if (user == "True")
            {
                UserId = System.Text.Encoding.Default.GetString(outToBytes);
            }
            ICurrentUser currentUser = context.RequestServices.GetService(typeof(ICurrentUser)) as ICurrentUser;
            IDatabaseService databaseService = context.RequestServices.GetService(typeof(IDatabaseService)) as IDatabaseService;
            currentUser.UserId = UserId;
            //currentUser.UserName = jsonToken.Claims.FirstOrDefault(obj => obj.Type == "UserName")?.Value;
            //currentUser.TokenId = userToken.Id;

            await _next(context);
        }

    }
}
