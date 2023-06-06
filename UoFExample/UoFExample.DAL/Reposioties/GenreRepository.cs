using UoFExample.DAL.Entities;
using UoFExample.DAL.Reposioties.Interfaces;

namespace UoFExample.DAL.Reposioties;

public class GenreRepository : BaseRepository<Genre>, IGenreRepository
{
    public GenreRepository(DataBaseContext context) : base(context)
    {
    }
}