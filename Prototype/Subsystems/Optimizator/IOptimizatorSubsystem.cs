using LogisticPlatformMVP.Prototype.DataModel.Map.Route;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticPlatformMVP.Prototype.Subsystems.Optimizator
{
    interface IOptimizatorSubsystem
    {
        double[] GetGrades(IRoute[] aRoutes);
    }
}
