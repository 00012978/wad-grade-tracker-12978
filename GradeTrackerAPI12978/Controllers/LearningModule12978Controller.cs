using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GradeTrackerAPI12978.Data;
using GradeTrackerAPI12978.Entities;
using GradeTrackerAPI12978.Data.DTOs.Modules;
using Mapster;

namespace GradeTrackerAPI12978.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LearningModule12978Controller : ControllerBase
    {
        private readonly MainDbContext _context;

        public LearningModule12978Controller(MainDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ModuleGetDTO12978>>> GetModules()
        {
            var modules = await _context.Modules.Include(t => t.Assignments).ToListAsync();
            var result = modules.Adapt<List<ModuleGetDTO12978>>();
            return result;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ModuleGetDTO12978>> GetLearningModule12978(int id)
        {
            var learningModule12978 = await _context.Modules.FindAsync(id);

            if (learningModule12978 == null)
            {
                return NotFound();
            }

            var res = learningModule12978.Adapt<ModuleGetDTO12978>();

            return res;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutLearningModule12978(int id, ModuleCreateDTO12978 req)
        {
            var module = req.Adapt<LearningModule12978>();
            module.Id = id;

            _context.Entry(module).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LearningModule12978Exists(id))
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
        public async Task<ActionResult<LearningModule12978>> PostLearningModule12978(ModuleCreateDTO12978 req)
        {
            var module = req.Adapt<LearningModule12978>();

            _context.Modules.Add(module);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLearningModule12978", new { id = module.Id }, req);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLearningModule12978(int id)
        {
            var learningModule12978 = await _context.Modules.FindAsync(id);
            if (learningModule12978 == null)
            {
                return NotFound();
            }

            _context.Modules.Remove(learningModule12978);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LearningModule12978Exists(int id)
        {
            return _context.Modules.Any(e => e.Id == id);
        }
    }
}
