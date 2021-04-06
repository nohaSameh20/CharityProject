using Charity.Persistence.ICore;
using Charity.Persistence.SeedManagement.Commands;
using CharityProject.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Charity.Persistence
{
    public class SeedManager
    {
        IDatabaseService databaseService;
        List<ISeedCommand> seedObjs = new List<ISeedCommand>();
        private void InititSeedList()
        {
            seedObjs.Add(new InitSeedCommand(databaseService));
            seedObjs.Add(new AddAnotherAdminSeed(databaseService));
        }

        public SeedManager(IDatabaseService databaseService)
        {
            this.databaseService = databaseService;
            this.InititSeedList();
        }

        public void Seed()
        {
            seedObjs.ForEach(obj => obj.Execute());
        }
    }
}
