using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticPlatformMVP.MVP
{
    class SimpleRoute
    {
        int[] m_aPath;
        double[][] m_aGraph;
        double[] m_aWaitingTimes;
        double m_fMaxLate = 0;
        double Grade
        {
            get;
        }
        public double DeliveryTime
        {
            get
            {
                double fDeliveryTime = m_aGraph[m_aPath[0]][m_aPath[1]];
                for (int i = 2; i < m_aPath.Length; i++)
                {
                    fDeliveryTime += m_aGraph[m_aPath[i - 1]][m_aPath[i]];
                }
                return fDeliveryTime;
            }
        }
        public double ReturningTime
        {
            get
            {
                double fReturningTime = m_aGraph[m_aPath[m_aPath.Length-1]][m_aPath[0]];
                return fReturningTime;
            }
        }
        public double AverageLate
        {
            get
            {
                double fAverageLate= SumLate() / m_aPath.Length;                
                return fAverageLate;
            }
        }
        public double MaxLate
        {
            get
            {
                SumLate();
                return m_fMaxLate;
            }
        }
        public SimpleRoute(double[][] aGraph, int iStartPoint, double[] aWaitingTimes)
        {
            if (aGraph!= null && aWaitingTimes!=null)
            {
                m_aGraph = new double[aGraph.Length][];
                for (int i = 0; i < aGraph.Length; i++)
                {
                    m_aGraph[i] = new double[aGraph[i].Length];
                    for (int j = 0; j < aGraph[i].Length; j++)
                    {
                        m_aGraph[i][j] = aGraph[i][j];
                    }                    
                }
                m_aPath = new int[m_aGraph.Length];
                m_aPath[0] = iStartPoint;
                m_aWaitingTimes = new double[aWaitingTimes.Length];
                for (int i = 0; i < aWaitingTimes.Length; i++)
                {
                    m_aWaitingTimes[i] = aWaitingTimes[i];
                }
            }
            else
            {
                throw new FormatException("Ошибка! Граф путей или массив ожиданий не может быть null.");
            }
        }
        private double SumLate()
        {
            double fSumLate = m_aGraph[m_aPath[0]][m_aPath[1]]-m_aWaitingTimes[m_aPath[1]],
                fTotalTime = fSumLate;
            m_fMaxLate = fSumLate;
            for (int i = 2; i < m_aPath.Length; i++)
            {
                fTotalTime += m_aGraph[m_aPath[i - 1]][m_aPath[i]];
                double fLate = fTotalTime - m_aWaitingTimes[m_aPath[i]];
                if (fLate>m_fMaxLate)
                {
                    m_fMaxLate = fLate;
                }
                fSumLate += fLate;
            }
            return fSumLate;
        }

    }
}
