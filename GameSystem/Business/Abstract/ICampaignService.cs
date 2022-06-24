using GameSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSystem.Business.Abstract
{
    public interface ICampaignService
    {
        bool isAvailableForCampaign(Customer customer);
        double ApplyForCampaign(Game game, Customer customer);
    }
}
