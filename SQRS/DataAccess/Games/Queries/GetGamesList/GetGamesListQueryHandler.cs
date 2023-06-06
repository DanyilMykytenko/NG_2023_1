using AutoMapper;
using AutoMapper.QueryableExtensions;
using DataAccess.Games.Queries.GetGameList;
using DataAccess.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Games.Queries.GetGamesList
{
    public class GetGamesListQueryHandler : IRequestHandler<GetGamesListQuery, GetGamesListVm>
    {
        private readonly GameDbContext _ctx;
        private readonly IMapper _mapper;

        public GetGamesListQueryHandler(GameDbContext ctx, IMapper mapper) 
        {
            _ctx = ctx;
            _mapper = mapper;
        }

        public async Task<GetGamesListVm> Handle(GetGamesListQuery request, CancellationToken cancellationToken)
        {
            var games = _ctx.Games.Select(x => x);
            if (!string.IsNullOrEmpty(request.Name))
                games = games.Where(x => x.Name.Contains(request.Name));
            var result = await games.ProjectTo<GameLookupDto>(_mapper.ConfigurationProvider).ToListAsync();

            return new GetGamesListVm { Games = result };
        }
    }
}
