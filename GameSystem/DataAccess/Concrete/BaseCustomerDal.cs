using GameSystem.DataAccess.Abstract;
using GameSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSystem.DataAccess.Concrete
{
    public class BaseCustomerDal : ICustomerDal
    {
        private DbSet<Customer> _object;
        Context c = new Context();

        public void Create(Customer customer)
        {
            _object.Add(customer);
            c.SaveChanges();
        }

        public void Delete(Customer customer)
        {
            _object.Remove(customer);
            c.SaveChanges();
        }

        public List<Customer> GetAll()
        {
            return _object.ToList();
        }

        public void Update(Customer customer)
        {
            c.SaveChanges();
        }
    }
}
