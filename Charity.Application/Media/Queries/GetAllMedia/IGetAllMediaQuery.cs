using CharityProject.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Charity.Application.Media
{
    public interface IGetAllMediaQuery
    {
        List<GetAllMediaQueryResult> Execute();
    }
}
