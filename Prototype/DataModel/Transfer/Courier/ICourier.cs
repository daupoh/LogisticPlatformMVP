using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticPlatformMVP.Prototype.DataModel.Transfer.Courier
{
    interface ICourier:IEntity
    {
        string FullName { get; set; }
    }
}
