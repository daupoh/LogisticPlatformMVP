using LogisticPlatformMVP.Prototype.DataModel.Transfer.Courier;
using LogisticPlatformMVP.Prototype.DataModel.Transfer.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticPlatformMVP.Prototype.DataModel.Transfer.OrderPool
{
    interface IOrderPool
    {
        string              StartAddress { get; set; }
        IList<IOrder>       Orders { get; }
        IList<ICourier>     Couriers { get; }
        int OrdersCount { get; }
        int CouriersCount { get; }

        ICourier GetCourierByNumber(int iNumber);
        IOrder GetOrderByNumber(int iNumber);
        void DeleteCourierByNumber(int iNumber);
        void DeleteOrderByNumber(int iNumber);

        void AddOrder(IOrder rOrder);
        void AddCourier(ICourier rCourier);

        void ClearOrders();
        void ClearCouriers();

    }
}
