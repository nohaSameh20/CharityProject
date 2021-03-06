using System;
using System.Collections.Generic;
using System.Text;

namespace CharityProject.Common
{
    public class AuthException : Exception
    {
        public string ClientMessage { set; get; }
        public AuthExceptionType AuthExceptionType { set; get; }

        public AuthException(string message, AuthExceptionType type)
        {
            this.ClientMessage = message;
            this.AuthExceptionType = type;
        }
    }
}
