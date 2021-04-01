using System;
using System.Collections.Generic;
using System.Text;

namespace Charity.Application.Countries 
{
    public interface ILoadCountryQuery
    {
        List<LoadCountryQueryResult> GetCountries();
    }

}
