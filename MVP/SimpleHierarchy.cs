using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticPlatformMVP.MVP
{
    class SimpleHierarchy
    {
        double[] m_aLateStandartGrade,
                 m_aTimeStandartGrade,
                    m_aLateStandartBorder,
                    m_aTimeStandartBorder,
                    m_aCriterionGrade,
                m_aRouteVector;
       
        public SimpleHierarchy()
        {
            m_aLateStandartGrade = new double[] { 0.51, 0.2638, 0.1296, 0.0636,0.0329 };
            m_aLateStandartBorder = new double[] { 60.0, 90.0, 120.0, 240.0, 1440.0 };            
            m_aTimeStandartGrade = new double[] { 0.6545, 0.2045, 0.0955, 0.0456 };
            m_aTimeStandartBorder = new double[] { 45.0, 75.0, 120.0, 1440.0 };           
            m_aCriterionGrade = new double[] { 0.5956, 0.2763, 0.0735, 0.0482 };
            m_aRouteVector = new double[4];
        }
        public double GetGrade (SimpleRoute rRoute)
        {
            double fGrade = 0;
            m_aRouteVector[0] = m_aLateStandartGrade[GetAverageLateBorderIndex(rRoute)];
            m_aRouteVector[1] = m_aLateStandartGrade[GetMaxLateBorderIndex(rRoute)];
            m_aRouteVector[2] = m_aTimeStandartGrade[GetDelivryTimeBorderIndex(rRoute)];
            m_aRouteVector[3] = m_aTimeStandartGrade[GetReturningTimeBorderIndex(rRoute)];
            for (int i = 0; i < 4; i++)
            {
                fGrade += m_aRouteVector[i] * m_aCriterionGrade[i];
            }
            return fGrade;
        }
        private int GetMaxLateBorderIndex (SimpleRoute rRoute)
        {
            return FindBorderIndex(rRoute.MaxLate, m_aLateStandartBorder);
        }
        private int GetAverageLateBorderIndex (SimpleRoute rRoute)
        {
            return FindBorderIndex(rRoute.AverageLate, m_aLateStandartBorder);
        }
        private int GetDelivryTimeBorderIndex(SimpleRoute rRoute)
        {
            return FindBorderIndex(rRoute.DeliveryTime, m_aTimeStandartBorder);
        }
        private int GetReturningTimeBorderIndex(SimpleRoute rRoute)
        {
            return FindBorderIndex(rRoute.ReturningTime, m_aTimeStandartBorder);
        }
        private int FindBorderIndex (double fValue, double[] aBorders)
        {
            int iSearchedIndex = 0;           
            while (iSearchedIndex<aBorders.Length-1 && aBorders[iSearchedIndex] < fValue)
            {
                iSearchedIndex++;
            }
            return iSearchedIndex;
        }
    }
}
