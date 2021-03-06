﻿using LogisticPlatformMVP.Prototype.DataModel.Transfer.OrderPool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticPlatformMVP.Prototype.Adapters.OrderManager
{
    interface IOrderManager
    {
        IOrderPool OrderPool { get; }
    }
}
