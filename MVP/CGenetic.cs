﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab1
{
    class CGenetic
    {
        CGroup m_rPopulation;
        readonly IGradeUpdater m_rUpdater;
        readonly CGenLaw m_rLaw;        
        double m_fLastBestGrade;
        public CGenetic(CGenLaw rLaw, IGradeUpdater rUpdater)
        {
            if (rLaw != null && rUpdater!=null)
            {
                m_rUpdater = rUpdater;
                m_rLaw = rLaw;              
                
            }
            else
            {
                throw new FormatException("Размер группы должен быть больше 0");
            }
        }
       public string ShowPopulation()
        {
            return m_rPopulation.ToString();
        }
        public void Evolution()
        {            
             CGroup rChilds = m_rPopulation.Selection().Crossbreeding();
                rChilds.Mutate();
                m_rPopulation.GenerateNewGroup(rChilds);            
        }
       
        public void InitializeGroup()
        {
            m_rPopulation = new CGroup(m_rUpdater, m_rLaw);
            m_rPopulation.GenerateChromosomes(m_rLaw.PopulationSize);
            m_fLastBestGrade = m_rPopulation.GetBestGrade();
        }       
      
        public bool IsNotEndOfEvolution()
        {
            bool bEvolutionNotEnded = true;
            double fCurrentBestGrade = m_rPopulation.GetBestGrade();
            if (m_rLaw.WaitCounter > 0)
            {
                if (fCurrentBestGrade < m_fLastBestGrade)
                {
                    m_fLastBestGrade = fCurrentBestGrade;
                }
                else
                {
                    m_rLaw.DecWaitCounter();
                }

            }
            else
            {
                bEvolutionNotEnded = false;
            }
            return bEvolutionNotEnded;
        }      
      
        public CChromosome GetBestChromosome()
        {
            return m_rPopulation.GetBestChromosome();
        }
        
    }
}
