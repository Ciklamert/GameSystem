using GameSystem.Business.Abstract;
using GameSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSystem.Business.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public double ApplyForCampaign(Game game, Customer customer)
        {
            if ((2022 - customer.RegisterYear) < 1 && customer.Point >= 1000)
            {
                Console.WriteLine("Which campaign do you want?\nEnter 1 for new Customer campaign\nEnter 2 for Point Campaign");
                int choice = Convert.ToInt32(Console.ReadLine());
                while (true)
                {
                    if (choice == 1)
                    {
                        return NewCustomerCampaign(game);
                    }
                    else if (choice == 2)
                    {
                        return PointCampaign(game);
                    }
                    else
                    {
                        Console.WriteLine("Please enter 1 or 2");
                        choice = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
                
            else if((2022 - customer.RegisterYear) < 1)
            {
                return NewCustomerCampaign(game);
            }
            else
            {
                return PointCampaign(game);
            }
        }

        public bool isAvailableForCampaign(Customer customer)
        {
            if((2022 - customer.RegisterYear) < 1 || customer.Point >= 1000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double NewCustomerCampaign(Game game)
        {
            return game.Price * 0.8;
        }
        public double PointCampaign(Game game)
        {
            return game.Price * 0.5;
        }

        
    }
}
