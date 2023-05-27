using UoFExample.DAL.Entities;

namespace UoFExample.DAL.Reposioties.Interfaces;

public interface IGameRepository : IRepository<Game>
{
    Task<IEnumerable<Game>> GetGamesWithGenre();
}