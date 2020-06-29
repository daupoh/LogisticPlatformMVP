using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogisticPlatformMVP.Prototype.Adapters.OrderManager;
using LogisticPlatformMVP.Prototype.Adapters.WebMap;
using LogisticPlatformMVP.Prototype.DataModel.Hierarchy.Border;
using LogisticPlatformMVP.Prototype.DataModel.Hierarchy.Criterion;
using LogisticPlatformMVP.Prototype.DataModel.Hierarchy.Standart;
using LogisticPlatformMVP.Prototype.DataModel.Map.Route;
using LogisticPlatformMVP.Prototype.DataModel.Transfer.Courier;
using LogisticPlatformMVP.Prototype.DataModel.Transfer.Order;
using LogisticPlatformMVP.Prototype.Subsystems.Assignement;
using LogisticPlatformMVP.Prototype.Subsystems.HierarchyGrades;
using LogisticPlatformMVP.Prototype.Subsystems.HierarchySettings;
using LogisticPlatformMVP.Prototype.Subsystems.Operating;

namespace LogisticPlatformMVP.Prototype
{
    class CPrototypeLogisticPlatform : ILogisticPlatform
    {
        private IOperatingSubsystem m_rOperating;
        private IGradeSettingSubsystem m_rGradeModelSettings;
     

        public CPrototypeLogisticPlatform()
        {

        }
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

        public IList<ICourier> GetCouriers()
        {
            throw new NotImplementedException();
        }

        public IList<IOrder> GetOrders()
        {
            throw new NotImplementedException();
        }

        public IList<IRoute> GetRoutes()
        {
            throw new NotImplementedException();
        }

        public bool IsModelConsistency()
        {
            throw new NotImplementedException();
        }

        public void Optimize()
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
