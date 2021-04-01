using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CharityProject.Common.Exceptions
{
    public class ValidationException:Exception
    {
        public List<ValidationResult> ValidationData { private set; get; } = new List<ValidationResult>();
        public string ClientMessage { set; get; }

        public ValidationException()
        {

        }

        public ValidationException(string clientMessage, string message)
            : base(message)
        {
            this.ClientMessage = clientMessage;
        }

        public ValidationException(string clientMessage, List<ValidationResult> validationResult)
        {
            this.ValidationData = validationResult;
            this.ClientMessage = clientMessage;
        }


    }
}
