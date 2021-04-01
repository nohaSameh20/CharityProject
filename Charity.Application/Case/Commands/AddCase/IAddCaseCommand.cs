using System;
using System.Collections.Generic;
using System.Text;

namespace Charity.Application
{
    public interface IAddCaseCommand
    {
        Guid Execute(AddCaseModel model);
    }
}
