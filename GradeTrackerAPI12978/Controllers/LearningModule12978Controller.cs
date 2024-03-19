using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GradeTracker12978.DAL.Repositories.LearningModules;
using GradeTracker12978.DAL.Data.DTOs.Modules;

namespace GradeTrackerAPI12978.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LearningModule12978Controller : ControllerBase
    {
        private readonly IModuleRepository _repository;

        public LearningModule12978Controller(IModuleRepository rep)
        {
            _repository = rep;
        }

        [HttpGet]
        public async Task<IEnumerable<ModuleGetDTO12978>> GetModules()
        {
            return await _repository.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ModuleGetDTO12978>> GetLearningModule12978(int id)
        {
            var learningModule12978 = await _repository.GetById(id);

            if (learningModule12978 == null)
            {
                return NotFound();
            }

            return learningModule12978;
        }

        [HttpPut("{id}")]
        public async Task PutLearningModule12978(int id, ModuleCreateDTO12978 req)
        {
            await _repository.Update(id, req);
        }

        [HttpPost]
        public async Task<ModuleGetDTO12978> PostLearningModule12978(ModuleCreateDTO12978 req)
        {
            return await _repository.Create(req);
        }

        [HttpDelete("{id}")]
        public async Task DeleteLearningModule12978(int id)
        {
            await _repository.Delete(id);
        }
    }
}
