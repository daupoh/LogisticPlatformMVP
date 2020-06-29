using LogisticPlatformMVP.Prototype.DataModel.Hierarchy.Border;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticPlatformMVP.Prototype.DataModel.Hierarchy.Standart
{
    interface IStandart
    {
        IList<IBorder> Borders { get; }
    }
}
