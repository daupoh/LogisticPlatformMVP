using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticPlatformMVP.Prototype.Adapters.WebMap
{
    interface IWebMap
    {
        double GetDistanceBetween(string sFirstAddress, string sSecondAddress);
    }
}
