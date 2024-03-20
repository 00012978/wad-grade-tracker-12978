using GradeTracker12978.DAL.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeTracker12978.DAL
{
    public class ModuleCalculationService : IModuleCalculationService12978
    {
        public ModuleCalculationService()
        {
            
        }
        public double? CalculateTotalMark(LearningModule12978 module)
        {
            double? totalMark = 0;
            double totalWeighting = 0;

            foreach (var assignment in module.Assignments)
            {
                totalMark += assignment.Grade * (assignment.Weighting / 100.0);
                totalWeighting += assignment.Weighting;
            }

            if (Math.Abs(totalWeighting - 100) > 0)
            {
                totalMark = null;
            }

            return totalMark;
        }
    }
}
