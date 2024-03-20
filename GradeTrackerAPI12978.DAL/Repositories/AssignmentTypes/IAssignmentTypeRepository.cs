using GradeTracker12978.DAL.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeTracker12978.DAL.Repositories.AssignmentTypes
{
    public interface IAssignmentTypeRepository
    {
        Task<IEnumerable<AssignmentType12978>> GetAll();
    }
}
