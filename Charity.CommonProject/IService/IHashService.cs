using System;
using System.Collections.Generic;
using System.Text;

namespace CharityProject.Common.IService
{
    public interface IHashService
    {
        string CreateSalt();
        string Create(string value, string salt);
        bool Validate(string value, string salt, string hash);
    }
}
