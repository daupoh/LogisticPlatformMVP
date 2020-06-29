using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogisticPlatformMVP.Prototype.DataModel.Hierarchy.Border;
using LogisticPlatformMVP.Prototype.DataModel.Hierarchy.Criterion;
using LogisticPlatformMVP.Prototype.DataModel.Hierarchy.Standart;
using LogisticPlatformMVP.Prototype.Subsystems.HierarchyGrades;

namespace LogisticPlatformMVP.Prototype.Subsystems.HierarchySettings
{
    abstract class ACGradeSetting : IGradeSettingSubsystem
    {
        private IGradeSubsystem m_rGradeModel;
       
        public IList<IStandart> Standarts => throw new NotImplementedException();

        public IList<ICriterion> Criterions => throw new NotImplementedException();

        public void AddStandart(IStandart rStandart)
        {
            throw new NotImplementedException();
        }

        public void AddStandartBorder(string sStandartName, IBorder rBorder)
        {
            throw new NotImplementedException();
        }

        public void ClearBorder(string sStandartName)
        {
            throw new NotImplementedException();
        }

        public void ClearStandartsForCriterion(string sCriterionName)
        {
            throw new NotImplementedException();
        }

        public void DeleteStandartBorderByNumber(string sStandartName, int iNumber)
        {
            throw new NotImplementedException();
        }

        public bool IsModelConsistency()
        {
            throw new NotImplementedException();
        }

        public void SetCriterionGrade(int iDominatingCriterion, int iSubmissiveCriterion, double fScaleGrade)
        {
            throw new NotImplementedException();
        }

        public void SetStandartGrade(int iDominatingStandart, int iSubmissiveStandart, double fScaleGrade)
        {
            throw new NotImplementedException();
        }

        public IList<IBorder> StandartBorders(string sStandartName)
        {
            throw new NotImplementedException();
        }
    }
}
