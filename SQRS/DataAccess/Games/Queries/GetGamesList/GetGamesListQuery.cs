using DataAccess.Games.Queries.GetGamesList;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Games.Queries.GetGameList
{
    public class GetGamesListQuery : IRequest<GetGamesListVm>
    {
        public string? Name { get; set; }
    }
}
