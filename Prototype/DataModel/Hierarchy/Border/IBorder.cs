using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticPlatformMVP.Prototype.DataModel.Hierarchy.Border
{
    interface IBorder
    {
        double MaxValue { get; }
        double MinValue { get; }
        bool IsInsideBorder(double fValue);
    }
}
