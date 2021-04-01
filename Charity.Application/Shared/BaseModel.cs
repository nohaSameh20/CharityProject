using CharityProject.Common.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Charity.Application.Shared
{
    public abstract class BaseModel
    {
        [JsonIgnore]
        protected ModelState modelState;


        protected virtual void Validate()
        {
            modelState = new ModelState();
            ValidationContext context = new ValidationContext(this);
            modelState.IsValid = Validator.TryValidateObject(this, context, modelState.ValidationResults, true);
        }

        public bool IsValid()
        {
            Validate();
            return modelState.IsValid;
        }

        [JsonIgnore]
        public virtual ModelState ValidationState
        {
            get
            {
                Validate();

                return modelState;
            }
        }
    }
}
