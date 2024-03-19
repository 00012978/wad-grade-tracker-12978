using GradeTracker12978.DAL.Data;
using GradeTracker12978.DAL.Data.DTOs.Assignments;
using GradeTracker12978.DAL.Data.Entities;
using Mapster;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeTracker12978.DAL.Repositories.Assignments
{
    public class AssignmentRepository : IAssignmentRepository
    {
        private readonly MainDbContext _context;

        public AssignmentRepository(MainDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<AssignmentGetDTO12978>> GetAll()
        {
            var assignments = await _context.Assignments
                .Include(a => a.Module)
                .Include(b => b.AssignmentType)
                .ToListAsync();
            var result = assignments.Adapt<List<AssignmentGetDTO12978>>();
            return result;
        }

        public async Task<AssignmentGetDTO12978?> GetById(int id)
        {
            var assignment = await _context.Assignments
                .Include(a => a.Module)
                .Include(b => b.AssignmentType).FirstOrDefaultAsync(t => t.Id == id);
            var result = assignment.Adapt<AssignmentGetDTO12978>();
            return result;
        }

        public async Task<AssignmentGetDTO12978> Create(AssignmentCreateDTO12978 assignment)
        {
            var req = assignment.Adapt<Assignment12978>();

            _context.Assignments.Add(req);
            await _context.SaveChangesAsync();

            var res = req.Adapt<AssignmentGetDTO12978>();
            return res;
        }

        public async Task Delete(int id)
        {
            var assignment = await _context.Assignments.FindAsync(id);
            if (assignment == null)
                throw new Exception($"Assignment (ID = {id}) not found.");

            _context.Assignments.Remove(assignment);
            await _context.SaveChangesAsync();
        }


        public async Task Update(int id, AssignmentCreateDTO12978 assignment)
        {
            var req = assignment.Adapt<Assignment12978>();
            req.Id = id;

            _context.Entry(req).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Assignment12978Exists(id))
                {
                    throw new Exception($"Assignment (ID = {id}) not found.");
                }
                else
                {
                    throw;
                }
            }
        }
        private bool Assignment12978Exists(int id)
        {
            return _context.Assignments.Any(e => e.Id == id);
        }
    }
}
