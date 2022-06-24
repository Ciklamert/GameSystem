using GameSystem.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSystem.Entities.Concrete
{
    public class Customer : IEntity
    {
        public Customer(int ıd, string firstName, string lastName, int registerYear, double point, double budget)
        {
            CustomerId = ıd;
            FirstName = firstName;
            LastName = lastName;
            RegisterYear = registerYear;
            Point = point;
            Budget = budget;
        }
    
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int RegisterYear { get; set; }
        public double Point { get; set; }
        public double Budget { get; set; }
    }
}
