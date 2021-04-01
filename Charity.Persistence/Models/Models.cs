using Charity.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Charity.Persistence.Models
{
    public class UserCharity
    {
        public UserCharity(string email,string firstName,string lastName)
        {
            Id = Guid.NewGuid();
            Email = email;
            FirstName = firstName;
            LastName = lastName;
        }

        public Guid Id { set; get; }
        public string Email { set; get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Password { get; set; }
        public UserRole role { set; get; }







    }
    public class CountrySD
    {
        public CountrySD(string shortName, string code, string name)
        {
            Name = name;
            ShortName = shortName;
            Code = code;
        }

        public CountrySD(string shortName, string code, string name, string arName)
        {
            Name = name;
            ShortName = shortName;
            Code = code;
            ArName = arName;
        }

        public CountrySD(string shortName, string code, string name, string arName, string nationality, string arNationality)
        {
            Name = name;
            ShortName = shortName;
            Code = code;
            ArName = arName;
            Nationality = nationality;
            ArNationality = arNationality;
        }


        public string Name { set; get; }
        public string ArName { set; get; }
        public string Nationality { set; get; }
        public string ArNationality { set; get; }


        public string ShortName { set; get; }
        public string Code { set; get; }
        public string Flag { set; get; }

        public bool InScope { set; get; }
    }
}
