using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogisticPlatformMVP.Prototype.DataModel.Hierarchy.Criterion;
using LogisticPlatformMVP.Prototype.DataModel.Hierarchy.Scales;
using LogisticPlatformMVP.Prototype.DataModel.Hierarchy.Standart;
using LogisticPlatformMVP.Prototype.DataModel.Map.Route;
using LogisticPlatformMVP.Prototype.Subsystems.HierarchyGrades;

namespace LogisticPlatformMVP.Prototype.DataModel.Hierarchy.GoalModel
{
    class CStandartModel : ACGradeModel, IGoalModel
    {        
        public IList<IStandart> Standarts => throw new NotImplementedException();

        public IList<ICriterion> Criterions => throw new NotImplementedException();
       
    }
}
