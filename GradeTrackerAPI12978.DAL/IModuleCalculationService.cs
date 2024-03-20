using GradeTracker12978.DAL.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeTracker12978.DAL
{
    public interface IModuleCalculationService12978
    {
        double? CalculateTotalMark(LearningModule12978 module);
    }
}
