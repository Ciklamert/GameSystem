using GameSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSystem.Business.Abstract
{
    public interface ICustomerService
    {
        void AddCustomer(Customer customer);
        void DeleteCustomer(Customer customer); 
        void UpdateCustomer(Customer customer);
        List<Customer> GetAllCustomers();

        void SaleGame(Game game,Customer customer);
    }
}
