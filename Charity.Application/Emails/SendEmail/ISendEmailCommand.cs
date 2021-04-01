using System;
using System.Collections.Generic;
using System.Text;

namespace Charity.Application.Emails
{
    public interface ISendEmailCommand
    {
        bool Execute(SendEmailModel model);
    }
}
