using LogisticPlatformMVP.Prototype.DataModel.Transfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticPlatformMVP.Prototype.DataModel.Map.GraphArc
{
    interface IGraphArc:IEntity
    {
        int FirstOrderNumber { get; }
        int SecondOrderNumber { get; }

        double StraightTimePath { get; }
        double BackPathTime { get; }
    }
}
