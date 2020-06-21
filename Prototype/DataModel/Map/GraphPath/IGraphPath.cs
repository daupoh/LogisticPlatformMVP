using LogisticPlatformMVP.Prototype.DataModel.Map.GraphArc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticPlatformMVP.Prototype.DataModel.Map.GraphPath
{
    interface IGraphPath
    {
        IList<IGraphArc> Arcs { get; }
        void SetPathTime(int iFirst, int iSecond, double fStraightTime, double fBackTime);
    }
}
