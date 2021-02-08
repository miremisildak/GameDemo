using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+"Campaign added");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "Campaign deleted");

        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "Campaign updated");

        }
    }
}
