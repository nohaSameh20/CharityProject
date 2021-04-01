using Charity.Application.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Charity.Application.Emails
{
    public class SendEmailModel:BaseModel
    {
        [Required(ErrorMessage ="Message Is Required")]
        public string Body { get; set; }

        [Required(ErrorMessage = "Name Is Required")]
        public string Subject { get; set; }
        public string SmtpAddress = "smtp.gmail.com";
        public int PortNumber = 587;
        public bool EnableSSL = true;
        [Required(ErrorMessage = "Email Is Required")]
        public string EmailFromAddress { get; set; }
        public string Password = "P@ssw0rd_Charity";
        public string EmailToAddress = "shababfeelkhier@gmail.com";   
    }
}
