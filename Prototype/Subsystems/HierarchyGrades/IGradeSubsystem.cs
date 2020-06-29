using LogisticPlatformMVP.Prototype.DataModel.Map.Route;
using LogisticPlatformMVP.Prototype.Subsystems.HierarchySettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticPlatformMVP.Prototype.Subsystems.HierarchyGrades
{
    interface IGradeSubsystem:IGradeSettingSubsystem
    {
        double GetRouteGrade(IRoute rRoute);
    }
}
