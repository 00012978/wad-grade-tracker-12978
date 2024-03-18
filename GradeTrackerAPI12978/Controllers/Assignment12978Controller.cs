using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GradeTrackerAPI12978.Data;
using GradeTrackerAPI12978.Entities;
using Mapster;
using GradeTrackerAPI12978.Data.DTOs.Assignments;

namespace GradeTrackerAPI12978.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Assignment12978Controller : ControllerBase
    {
        private readonly MainDbContext _context;

        public Assignment12978Controller(MainDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AssignmentGetDTO12978>>> GetAssignments()
        {
            var assignments = await _context.Assignments
                .Include(a => a.Module)
                .Include(b => b.AssignmentType)
                .ToListAsync();
            var result = assignments.Adapt<List<AssignmentGetDTO12978>>();
            return result;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AssignmentGetDTO12978>> GetAssignment12978(int id)
        {
            var assignment12978 = await _context.Assignments.FindAsync(id);

            if (assignment12978 == null)
            {
                return NotFound();
            }

            var result = assignment12978.Adapt<AssignmentGetDTO12978>();

            return result;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAssignment12978(int id, AssignmentCreateDTO12978 req)
        {
            var assignment = req.Adapt<Assignment12978>();
            assignment.Id = id;

            _context.Entry(assignment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Assignment12978Exists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<AssignmentGetDTO12978>> PostAssignment12978(AssignmentCreateDTO12978 assignment12978)
        {
            var req = assignment12978.Adapt<Assignment12978>();
            
            _context.Assignments.Add(req);
            await _context.SaveChangesAsync();

            var res = req.Adapt<AssignmentGetDTO12978>();
            return CreatedAtAction("GetAssignment12978", new { id = req.Id }, assignment12978);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAssignment12978(int id)
        {
            var assignment12978 = await _context.Assignments.FindAsync(id);
            if (assignment12978 == null)
            {
                return NotFound();
            }

            _context.Assignments.Remove(assignment12978);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Assignment12978Exists(int id)
        {
            return _context.Assignments.Any(e => e.Id == id);
        }
    }
}
