using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogisticPlatformMVP.Prototype.DataModel.Map.Route;

namespace LogisticPlatformMVP.Prototype.Subsystems.HierarchyGrades
{
    abstract class ACGradeModel : IGradeSubsystem
    {
        public double GetRouteGrade(IRoute rRoute)
        {
            throw new NotImplementedException();
        }
    }
}
