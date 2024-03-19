using GradeTracker12978.DAL.Data.DTOs.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeTracker12978.DAL.Repositories.LearningModules
{
    public interface IModuleRepository
    {
        Task<IEnumerable<ModuleGetDTO12978>> GetAll();
        Task<ModuleGetDTO12978?> GetById(int id);
        Task<ModuleGetDTO12978> Create(ModuleCreateDTO12978 module);
        Task Update(int id, ModuleCreateDTO12978 module);
        Task Delete(int id);
    }
}
