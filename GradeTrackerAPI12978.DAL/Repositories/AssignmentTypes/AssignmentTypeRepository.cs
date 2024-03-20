using GradeTracker12978.DAL.Data;
using GradeTracker12978.DAL.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeTracker12978.DAL.Repositories.AssignmentTypes
{
    public class AssignmentTypeRepository : IAssignmentTypeRepository
    {
        private readonly MainDbContext _context;

        public AssignmentTypeRepository(MainDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<AssignmentType12978>> GetAll()
        {
            return await _context.AssignmentTypes.ToListAsync();
        }
    }
}
