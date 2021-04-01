using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace Charity.Application.Emails
{
    public class SendEmailCommand : ISendEmailCommand
    {
        public bool Execute(SendEmailModel model)
        {
            using (MailMessage mail = new MailMessage(model.EmailFromAddress,model.EmailToAddress))
            {
                mail.Subject = model.Subject;
                mail.Body = model.Body;
                mail.IsBodyHtml = true;

                using (SmtpClient smtp = new SmtpClient(model.SmtpAddress, model.PortNumber))
                {
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential(model.EmailToAddress, model.Password);
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }
            }
            return true;
        }
    }
}
