﻿using LogisticPlatformMVP.Prototype.DataModel.Map.GraphPath;
using LogisticPlatformMVP.Prototype.DataModel.Transfer;
using LogisticPlatformMVP.Prototype.DataModel.Transfer.OrderPool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticPlatformMVP.Prototype.DataModel.Map.Route
{
    interface IRoute:IEntity
    {
        int[] Path { get; }
        IGraphPath Graph { get; }      
        double Grade { get; }
        double DeliveryTime { get; }
        double ReturningTime { get; }
         
    }
}
