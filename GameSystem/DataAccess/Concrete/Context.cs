using GameSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSystem.DataAccess.Concrete
{
    public class Context :DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Game> Games { get; set; }
    }
}
