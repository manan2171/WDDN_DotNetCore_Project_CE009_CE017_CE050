using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMVC.Models
{
    public interface IStudent
    {
        IEnumerable<Branch> GetBranches();
    }
}
