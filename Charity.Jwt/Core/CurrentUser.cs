using CharityProject.Common.IService;
using System;
using System.Collections.Generic;
using System.Text;

namespace CharityProject.JWT.Core
{
    public class CurrentUser : ICurrentUser
    {
        public CurrentUser()
        {

        }
        public CurrentUser(string Id, string UserName)
        {
            this.UserId = Id;
            this.UserName = UserName;
        }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public Guid TokenId { get; set; }
    }
}
