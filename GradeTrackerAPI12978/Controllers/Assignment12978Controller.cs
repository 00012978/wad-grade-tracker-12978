using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GradeTracker12978.DAL.Data.DTOs.Assignments;
using GradeTracker12978.DAL.Repositories.Assignments;
using Microsoft.AspNetCore.Mvc;

namespace GradeTrackerAPI12978.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Assignment12978Controller : ControllerBase
    {
        private readonly IAssignmentRepository _repository;

        public Assignment12978Controller(IAssignmentRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<AssignmentGetDTO12978>> GetAssignments()
        {
            return await _repository.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AssignmentGetDTO12978>> GetAssignment12978(int id)
        {
            var result = await _repository.GetById(id);

            if (result == null)
            {
                return NotFound();
            }

            return result;
        }

        [HttpPut("{id}")]
        public async Task PutAssignment12978(int id, AssignmentCreateDTO12978 req)
        {
            await _repository.Update(id, req);
        }

        [HttpPost]
        public async Task<AssignmentGetDTO12978> PostAssignment12978(AssignmentCreateDTO12978 assignment12978)
        {
            return await _repository.Create(assignment12978);
        }

        [HttpDelete("{id}")]
        public async Task DeleteAssignment12978(int id)
        {
            await _repository.Delete(id);
        }
    }
}
