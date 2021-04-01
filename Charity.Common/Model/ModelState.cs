using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityProject.Common.Model
{
  public class ModelState
  {
    public bool IsValid { set; get; }
    public List<ValidationResult> ValidationResults { set; get; }

    public ModelState()
    {
      ValidationResults = new List<ValidationResult>();
    }
  }
}
