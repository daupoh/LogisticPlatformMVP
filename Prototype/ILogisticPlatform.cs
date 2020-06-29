using LogisticPlatformMVP.Prototype.Subsystems.HierarchySettings;
using LogisticPlatformMVP.Prototype.Subsystems.Operating;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticPlatformMVP.Prototype
{
    interface ILogisticPlatform:IOperatingSubsystem, IGradeSettingSubsystem
    {
    }
}
