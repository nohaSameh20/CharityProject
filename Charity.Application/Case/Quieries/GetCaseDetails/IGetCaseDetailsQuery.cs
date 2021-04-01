using System;
using System.Collections.Generic;
using System.Text;

namespace Charity.Application.Case
{
    public interface IGetCaseDetailsQuery
    {
        GetCaseDetailsQueryResult Execute(Guid Id);
    }
}
