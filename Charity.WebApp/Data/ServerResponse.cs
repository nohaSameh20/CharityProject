using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity.Web.Data
{
    public class ServerResponse<T>
    {
        public T Result { set; get; }
        public ServerResponse()
        {
            Result = default(T);
        }
        public ServerResponse(T resultObject) : this()
        {
            Result = resultObject;
        }
        public static implicit operator ServerResponse<T>(T result)
        {
            return new ServerResponse<T>() { Result = result };
        }

    }

    public class CharityResponse : ServerResponse<object>
    {
        public static CharityResponse Void
        {
            get
            {
                return new CharityResponse();
            }
        }

        public CharityResponse()
        {
            Result = null;
        }
    }
}
