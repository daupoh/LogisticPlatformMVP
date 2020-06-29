using LogisticPlatformMVP.Prototype.DataModel.Map.Route;
using LogisticPlatformMVP.Prototype.DataModel.Transfer.Courier;
using LogisticPlatformMVP.Prototype.DataModel.Transfer.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticPlatformMVP.Prototype.Subsystems.Operating
{
    interface IOperatingSubsystem
    {
        IList<IOrder> GetOrders();
        IList<ICourier> GetCouriers();
        IList<IRoute> GetRoutes();
        void Optimize();
    }
}
