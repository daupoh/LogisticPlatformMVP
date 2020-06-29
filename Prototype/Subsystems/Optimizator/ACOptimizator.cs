using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogisticPlatformMVP.Prototype.DataModel.Map.Route;
using LogisticPlatformMVP.Prototype.Subsystems.HierarchyGrades;

namespace LogisticPlatformMVP.Prototype.Subsystems.Optimizator
{
    abstract class ACOptimizator : IOptimizatorSubsystem
    {
        private IGradeSubsystem m_rGradeModel;
       
        public double[] GetGrades(IRoute[] aRoutes)
        {
            throw new NotImplementedException();
        }
    }
}
