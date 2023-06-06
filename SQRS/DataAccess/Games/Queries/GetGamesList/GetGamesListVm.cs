using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Games.Queries.GetGamesList
{
    public class GetGamesListVm
    {
        public ICollection<GameLookupDto> Games { get; set; }
    }
}
