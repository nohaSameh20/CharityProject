using CharityProject.Application.Interfaces;
using CharityProject.Common.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Charity.Application.Countries
{
    public class LoadCountryQuery : ILoadCountryQuery
    {
        private readonly IDatabaseService databaseService;

        public LoadCountryQuery(IDatabaseService databaseService )
        {
            this.databaseService = databaseService;
        }
        public List<LoadCountryQueryResult> GetCountries()
        {
            List<LoadCountryQueryResult> res = databaseService.Countries.GetAll()
                                                            .Select(obj => new LoadCountryQueryResult(obj))
                                                            .OrderBy(obj => obj.Name).ToList();

            return res;
        }
    }
}
