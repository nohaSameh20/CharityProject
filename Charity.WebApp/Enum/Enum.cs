using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity.WebApp.Enum
{

    public enum EventType
    {
        Image = 1,
        Vedio = 2
    }
    public enum CaseGender
    {
        Male = 1,
        Female = 2
    }
    public enum Religion
    {
        Muslim = 1,
        NonMuslim = 2
    }
    public enum Entitytype
    {
        Organization = 1
    }

    public enum CardType
    {
        Visa=1,
        MasterCard=2,
        AmericanExpress=3,
        Discover=4,
        Maestro=5,
        JCB
    }
}
