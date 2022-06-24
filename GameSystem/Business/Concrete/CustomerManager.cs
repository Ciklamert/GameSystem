using GameSystem.Business.Abstract;
using GameSystem.DataAccess.Abstract;
using GameSystem.DataAccess.Concrete;
using GameSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSystem.Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal;
        private ICheckService _checkService;
        private ICampaignService _campaignService;
        public CustomerManager()
        {
            _customerDal = new BaseCustomerDal();
            _checkService = new CheckManager();
            _campaignService = new CampaignManager();
        }
        public void AddCustomer(Customer customer)
        {
            if (_checkService.CheckIfRealPerson(customer))
            {
                _customerDal.Create(customer);
            }
            else
            {
                Console.WriteLine("You cannot add this customer. Please enter a real person");
            }
        }

        public void DeleteCustomer(Customer customer)
        {
            _customerDal.Delete(customer);
        }

        public List<Customer> GetAllCustomers()
        {
            return _customerDal.GetAll();
        }

        public void SaleGame(Game game, Customer customer)
        {
            double price = 0;
            
            if (_campaignService.isAvailableForCampaign(customer))
            {
                Console.WriteLine("Do you want a campaign?");
                string choice = Console.ReadLine();
                if (choice.Equals("Yes"))
                {
                    double newPrice = _campaignService.ApplyForCampaign(game,customer);
                    price = newPrice;
                }else
                {
                    price = game.Price;
                }
            }
            else
            {
                price = game.Price;
            }
            if(customer.Budget >= price)
            {
                customer.Budget -= price;
                Console.WriteLine(game.Name + " has saled to " + customer.FirstName + " " + customer.LastName);
            }
            else
            {
                Console.WriteLine("You cannot buy this game because you don't have enough budget");
            }
        }

        public void UpdateCustomer(Customer customer)
        {
            _customerDal.Update(customer);
        }
    }
}
