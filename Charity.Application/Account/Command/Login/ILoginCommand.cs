using System;
using System.Collections.Generic;
using System.Text;

namespace Charity.Application.Account
{
    public interface ILoginCommand
    {
        string Execute(LoginModel model);
    }
}
