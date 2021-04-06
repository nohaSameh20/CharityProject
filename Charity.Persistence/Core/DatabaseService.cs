using Microsoft.EntityFrameworkCore;
using System;
using CharityProject.Persistance.Core;
using CharityProject.Application.Interfaces;
using Charity.Domain.Address;
using Charity.Domain.Adreess;
using CharityProject.Domain;
using Charity.Domain.Medias;
using Charity.Domain.Cases;

namespace CharityProject.Persistance
{
    public class DatabaseService : DbContext, IDatabaseService
    {
        private string connectionString= "Data Source=SQL5103.site4now.net;Initial Catalog=DB_A71CC3_NohaSamehGomaa;User Id=DB_A71CC3_NohaSamehGomaa_admin;Password=P@ssw0rd";
        private IServiceProvider provider;
        public DatabaseService(  IServiceProvider provider, IDatabaseServiceOptions options)
        {
            this.provider = provider;
            this.connectionString = options.ConnectionString;
        }

        internal DbSet<City> Cities { set; get; }
        internal DbSet<Country> Countries { set; get; }
        internal DbSet<User> Users { set; get; }
        internal DbSet<Media> Medias { set; get; }
        internal DbSet<Case> Cases { set; get; }
        internal DbSet<Nationality> Nationalities { get; set; }


        IRepository<City> IDatabaseService.Cities
        {
            get
            {
                return new Repository<City>(provider);
            }

        }

        IRepository<Country> IDatabaseService.Countries
        {
            get
            {
                return new Repository<Country>(provider);
            }

        }

        IRepository<Nationality> IDatabaseService.Nationalities
        {
            get
            {
                return new Repository<Nationality>(provider);
            }

        }

        IRepository<User> IDatabaseService.Users
        {
            get
            {
                return new Repository<User>(provider);
            }

        }


        IRepository<Media> IDatabaseService.Medias
        {
            get
            {
                return new Repository<Media>(provider);
            }

        }

        IRepository<Case> IDatabaseService.Cases
        {
            get
            {
                return new Repository<Case>(provider);
            }

        }
        public DatabaseService(IDataBaseServiceOptions options) : base()
        {
            this.connectionString = options.ConnectionString;
            provider = options.Provider;
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        void IDatabaseService.SaveChanges()
        {
            this.SaveChanges();
        }
         
    }
}
