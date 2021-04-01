using System;
using System.Collections.Generic;
using System.Text;

namespace Charity.Application.Media
{
    public interface IGetMediaByIdQuery
    {
        GetMediaByIdQueryResult Execute(Guid id);
    }
}
