using GameSimulation.Enities;
using GameSimulation.Abstract;
using System;
using System.Collections.Generic;
using System.Text;


namespace GameSimulation.Abstract
{
    interface ICampaignService
    {
        void Add(Campaign campaign);
        void Remove(Campaign campaign);
    }
}
