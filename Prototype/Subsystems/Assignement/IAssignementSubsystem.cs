using LogisticPlatformMVP.Prototype.DataModel.Map.GraphPath;
using LogisticPlatformMVP.Prototype.DataModel.Map.Route;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticPlatformMVP.Prototype.Subsystems.Assignement
{
    interface IAssignementSubsystem
    {
        IDictionary<int, IRoute> Optimize(IGraphPath rGraph);
    }
}
