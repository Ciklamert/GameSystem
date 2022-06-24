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
    public class BaseGameDal : IGameDal
    {
        private DbSet<Game> _object;
        Context c = new Context();

        public void Create(Game game)
        {
            _object.Add(game);
            c.SaveChanges();
        }

        public void Delete(Game game)
        {
            _object.Remove(game);
            c.SaveChanges();
        }

       

        public List<Game> GetAll()
        {
            return _object.ToList();
        }

        public void Update(Game game)
        {
            c.SaveChanges();
        }
    }
}
