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
    public class GameManager : IGameService
    {
        private IGameDal _gameDal;
        public GameManager()
        {
            _gameDal = new BaseGameDal();
        }
        public void AddGame(Game game)
        {
            _gameDal.Create(game);
        }

        public void DeleteGame(Game game)
        {
            _gameDal.Delete(game);
        }

        public List<Game> GetAllGames()
        {
            return _gameDal.GetAll();
        }

       

        public void UpdateGame(Game game)
        {
            _gameDal.Update(game);
        }
    }
}
