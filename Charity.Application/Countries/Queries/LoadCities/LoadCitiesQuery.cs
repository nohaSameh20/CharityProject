using CharityProject.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Charity.Application.Countries
{
    public class LoadCitiesQuery : ILoadCitiesQuery
    {
        private readonly IDatabaseService databaseService;

        public LoadCitiesQuery(IDatabaseService databaseService)
        {
            this.databaseService = databaseService;
        }
        public List<LoadCitiesQueryResult> Execute()
        {
            List<LoadCitiesQueryResult> res = databaseService.Cities.GetAll()
                                                            .Select(obj => new LoadCitiesQueryResult(obj))
                                                            .OrderBy(obj => obj.Name).ToList();

            return res;
        }
    }
}
