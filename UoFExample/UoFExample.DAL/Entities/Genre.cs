using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace UoFExample.DAL.Entities;

public class Genre : BaseEntity
{
    [Required]
    [Column(TypeName = "nvarchar(120)")]
    public string Name { get; set; }

    public virtual ICollection<Game> Games { get; set; }
}