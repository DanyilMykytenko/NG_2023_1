namespace UoFExample.DAL.Entities;

public class Game : BaseEntity
{
    public string Name { get; set; }

    public string? Desc { get; set; }

    public Guid? GenreId { get; set; }

    public virtual Genre Genre { get; set; }
}