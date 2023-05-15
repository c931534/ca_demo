using Domain.Entities;

namespace Application.Common
{
    public interface IRepository
    {
        public Game FindById(int Id);
        public void Save(Game game);
    }
}
