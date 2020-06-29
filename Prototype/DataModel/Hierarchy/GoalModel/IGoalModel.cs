using LogisticPlatformMVP.Prototype.DataModel.Hierarchy.Criterion;
using LogisticPlatformMVP.Prototype.DataModel.Hierarchy.Scales;
using LogisticPlatformMVP.Prototype.DataModel.Hierarchy.Standart;
using LogisticPlatformMVP.Prototype.Subsystems.HierarchyGrades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticPlatformMVP.Prototype.DataModel.Hierarchy.GoalModel
{
    interface IGoalModel
    {   
        IList<IStandart> Standarts { get; }
        IList<ICriterion> Criterions { get; }

    }
}
