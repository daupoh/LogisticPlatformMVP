using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticPlatformMVP.Prototype.DataModel.Transfer.Order
{
    interface IOrder:IEntity
    {
        string      Address { get; set; }
        int         WaitingTime { get; set; }
        DateTime    OrderTime { get; set; }
        int         RestOfWaitingTime { get; set; }

    }
}
