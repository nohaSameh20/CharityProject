using System;
using System.Collections.Generic;
using System.Text;

namespace Charity.Application.Media
{
    public interface IAddMediaCommand
    {
        Guid Execute(AddMediaModel model);
    }
}
