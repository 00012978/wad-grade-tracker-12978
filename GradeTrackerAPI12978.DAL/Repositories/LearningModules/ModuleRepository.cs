using GradeTracker12978.DAL.Data;
using GradeTracker12978.DAL.Data.DTOs.Modules;
using GradeTracker12978.DAL.Data.Entities;
using Mapster;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace GradeTracker12978.DAL.Repositories.LearningModules
{
    public class ModuleRepository : IModuleRepository
    {
        private readonly MainDbContext _context;
        private readonly IModuleCalculationService12978 _calculationService;

        public ModuleRepository(MainDbContext context, IModuleCalculationService12978 calculationService)
        {
            _context = context;
            _calculationService = calculationService;
        }
        public async Task<IEnumerable<ModuleGetDTO12978>> GetAll()
        {
            var modules = await _context.Modules.Include(m => m.Assignments).ToListAsync();
            foreach (var module in modules)
            {
                module.TotalMark = _calculationService.CalculateTotalMark(module);
            }
            var result = modules.Adapt<List<ModuleGetDTO12978>>();
            return result;
        }

        public async Task<ModuleGetDTO12978?> GetById(int id)
        {
            var module = await _context.Modules.Include(m => m.Assignments).FirstOrDefaultAsync(m => m.Id == id);
            if (module != null)
                module.TotalMark = _calculationService.CalculateTotalMark(module);
            var res = module?.Adapt<ModuleGetDTO12978>();
            return res;
        }

        public async Task<ModuleGetDTO12978> Create(ModuleCreateDTO12978 module)
        {
            var req = module.Adapt<LearningModule12978>();

            _context.Modules.Add(req);
            await _context.SaveChangesAsync();
            
            var res = req.Adapt<ModuleGetDTO12978>();

            return res;
        }

        public async Task Delete(int id)
        {
            var module = await _context.Modules.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (module == null)
                throw new Exception($"Module (ID = {id}) not found.");

            _context.Modules.Remove(module);
            await _context.SaveChangesAsync();
        }


        public async Task Update(int id, ModuleCreateDTO12978 module)
        {
            var req = module.Adapt<LearningModule12978>();
            req.Id = id;

            _context.Entry(req).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LearningModule12978Exists(id))
                {
                    throw new Exception($"Module (ID = {id}) not found.");
                }
                else
                {
                    throw;
                }
            }
        }

        private bool LearningModule12978Exists(int id)
        {
            return _context.Modules.Any(e => e.Id == id);
        }
    }
}
