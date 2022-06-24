using GameSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSystem.Business.Abstract
{
    public interface IGameService
    {
        void AddGame(Game game);
        void DeleteGame(Game game); 
        void UpdateGame(Game game);
        List<Game> GetAllGames();
    }
}
