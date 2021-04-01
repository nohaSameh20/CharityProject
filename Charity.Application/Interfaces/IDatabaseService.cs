using Charity.Domain;
using Charity.Domain.Address;
using Charity.Domain.Adreess;
using Charity.Domain.Cases;
using Charity.Domain.Medias;
using CharityProject.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CharityProject.Application.Interfaces
{
    public interface IDatabaseService
    {
        IRepository<City> Cities { get; }
        IRepository<Country> Countries { get; }
        IRepository<Nationality> Nationalities { get;}
        IRepository<User> Users { get; }
        IRepository<Media> Medias { get; }
        IRepository<Case> Cases { get; }

        //bool ExecuteTransaction(Action transactionBody);
        void SaveChanges();
    }
}
