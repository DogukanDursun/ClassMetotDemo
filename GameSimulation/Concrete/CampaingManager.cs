using GameSimulation.Enities;
using GameSimulation.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulation.Concrete
{
    public class CampaingManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " " + "Kampanyası Başladı");
        }

        public void Remove(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " " + "Kampanyası Sona Erdi");
        }
    }
}
