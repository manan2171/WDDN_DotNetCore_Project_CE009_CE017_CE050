using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMVC.Models
{
    public class SqlStudent : IStudent
    {
        private readonly StudentContext context;

        public SqlStudent(StudentContext context)
        {
            this.context = context;
        }

        IEnumerable<Branch> IStudent.GetBranches()
        {
            return context.Branches;
        }
    }
}
