using Application.Common;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFRepository
{
    public class GameRepository : DbContext, IRepository
    {
        public Game FindById(int id)
        {
            #region For Debug

            return new Game(id);

            #endregion

            //return Set<Game>().First(x => x.Id == id);
        }

        public void Save(Game game)
        {
            //Add(game); // or Update(game);

            //SaveChanges();
        }
    }
}
