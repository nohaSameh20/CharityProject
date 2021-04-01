using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityProject.Persistance.Core
{
  public interface IDataBaseServiceOptions
  {
    string ConnectionString { set; get; }
    IServiceProvider Provider { set; get; }
  }
}
