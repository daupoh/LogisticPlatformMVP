using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogisticPlatformMVP.Prototype.Adapters.OrderManager;
using LogisticPlatformMVP.Prototype.Adapters.WebMap;
using LogisticPlatformMVP.Prototype.DataModel.Map.Route;
using LogisticPlatformMVP.Prototype.DataModel.Transfer.Courier;
using LogisticPlatformMVP.Prototype.DataModel.Transfer.Order;
using LogisticPlatformMVP.Prototype.Subsystems.Assignement;

namespace LogisticPlatformMVP.Prototype.Subsystems.Operating
{
    abstract class ACOperating : IOperatingSubsystem
    {
        private IWebMap m_rWebMap;
        private IOrderManager m_rOrderManager;
        private IAssignementSubsystem m_rAssignement;

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

        public void Optimize()
        {
            throw new NotImplementedException();
        }
    }
}
