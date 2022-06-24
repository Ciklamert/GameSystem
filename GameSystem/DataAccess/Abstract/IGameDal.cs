using GameSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSystem.DataAccess.Abstract
{
    public interface IGameDal
    {
        void Create(Game game);
        List<Game> GetAll();
        void Update(Game game);
        void Delete(Game game);
    }
}
