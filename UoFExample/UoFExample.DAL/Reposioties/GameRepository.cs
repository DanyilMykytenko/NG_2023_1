using Microsoft.EntityFrameworkCore;
using UoFExample.DAL.Entities;
using UoFExample.DAL.Reposioties.Interfaces;

namespace UoFExample.DAL.Reposioties;

public class GameRepository : BaseRepository<Game>, IGameRepository
{
    public GameRepository(DataBaseContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Game>> GetGamesWithGenre()
    {
        var games = await _dbSet.Include(x => x.Genre).ToListAsync();

        return games;
    }
}