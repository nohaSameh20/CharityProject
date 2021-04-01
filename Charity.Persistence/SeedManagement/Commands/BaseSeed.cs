using Charity.Persistence.ICore;
using Charity.Persistence.Models;
using CharityProject.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Charity.Persistence.SeedManagement
{
    public abstract class BaseSeed : ISeedCommand
    {
        protected IDatabaseService databaseService;
        protected ConstData DATA;

        public BaseSeed(IDatabaseService databaseService)
        {
            this.databaseService = databaseService;
            DATA = new ConstData();
        }

        public abstract void Execute();

      
    }
}
