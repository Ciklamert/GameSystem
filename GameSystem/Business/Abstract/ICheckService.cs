using GameSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSystem.Business.Abstract
{
    public interface ICheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
