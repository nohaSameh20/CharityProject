using System;

namespace CharityProject.Common.IService
{
    public interface ICurrentUser
    {
        string UserId { set; get; }
        string UserName { set; get; }
        Guid TokenId { set; get; }
    }
}
