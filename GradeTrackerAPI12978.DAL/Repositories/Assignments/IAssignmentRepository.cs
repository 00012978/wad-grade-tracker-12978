using GradeTracker12978.DAL.Data.DTOs.Assignments;
using GradeTracker12978.DAL.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeTracker12978.DAL.Repositories.Assignments
{
    public interface IAssignmentRepository
    {
        Task<IEnumerable<AssignmentGetDTO12978>> GetAll();
        Task<AssignmentGetDTO12978?> GetById(int id);
        Task<AssignmentGetDTO12978> Create(AssignmentCreateDTO12978 assignment);
        Task Update(int id, AssignmentCreateDTO12978 assignment);
        Task Delete(int id);
    }
}
