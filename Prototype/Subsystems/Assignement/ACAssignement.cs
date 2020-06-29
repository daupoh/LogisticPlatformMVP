using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogisticPlatformMVP.Prototype.DataModel.Map.GraphPath;
using LogisticPlatformMVP.Prototype.DataModel.Map.Route;
using LogisticPlatformMVP.Prototype.Subsystems.Optimizator;

namespace LogisticPlatformMVP.Prototype.Subsystems.Assignement
{
    abstract class ACAssignement : IAssignementSubsystem
    {
        private IOptimizatorSubsystem m_rOptimizator;
        public IDictionary<int, IRoute> Optimize(IGraphPath rGraph)
        {
            throw new NotImplementedException();
        }
    }
}
