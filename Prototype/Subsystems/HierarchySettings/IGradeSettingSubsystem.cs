using LogisticPlatformMVP.Prototype.DataModel.Hierarchy.Border;
using LogisticPlatformMVP.Prototype.DataModel.Hierarchy.Criterion;
using LogisticPlatformMVP.Prototype.DataModel.Hierarchy.Standart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticPlatformMVP.Prototype.Subsystems.HierarchySettings
{
    interface IGradeSettingSubsystem
    {
        IList<IStandart> Standarts { get; }
        IList<ICriterion> Criterions { get; }
        IList<IBorder> StandartBorders(string sStandartName);
        void ClearStandartsForCriterion(string sCriterionName);
        void AddStandart(IStandart rStandart);
        void AddStandartBorder(string sStandartName, IBorder rBorder);
        void DeleteStandartBorderByNumber (string sStandartName, int iNumber);
        void ClearBorder(string sStandartName);
        void SetStandartGrade(int iDominatingStandart, int iSubmissiveStandart, double fScaleGrade);
        void SetCriterionGrade(int iDominatingCriterion, int iSubmissiveCriterion, double fScaleGrade);
        bool IsModelConsistency();
    }
}
