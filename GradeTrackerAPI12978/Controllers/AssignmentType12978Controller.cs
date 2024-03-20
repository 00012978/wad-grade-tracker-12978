using GradeTracker12978.DAL.Data.Entities;
using GradeTracker12978.DAL.Repositories.AssignmentTypes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GradeTrackerAPI12978.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssignmentType12978Controller : ControllerBase
    {
        private readonly IAssignmentTypeRepository _repository;

        public AssignmentType12978Controller(IAssignmentTypeRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<AssignmentType12978>> GetAssignments()
        {
            return await _repository.GetAll();
        }
    }
}
