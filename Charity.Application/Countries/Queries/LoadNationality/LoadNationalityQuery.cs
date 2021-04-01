using CharityProject.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Charity.Application.Countries
{
    public class LoadNationalityQuery : ILoadNationalityQuery
    {
        private readonly IDatabaseService databaseService;

        public LoadNationalityQuery(IDatabaseService databaseService)
        {
            this.databaseService = databaseService;
        }
        public List<LoadNationalityQueryResult> Execute()
        {
            List<LoadNationalityQueryResult> res = databaseService.Nationalities.GetAll()
                                                            .Select(obj => new LoadNationalityQueryResult(obj))
                                                            .OrderBy(obj => obj.Name).ToList();

            return res;
        }
    }
}
