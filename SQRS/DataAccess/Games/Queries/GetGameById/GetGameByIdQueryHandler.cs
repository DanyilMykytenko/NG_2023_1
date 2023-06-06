using AutoMapper;
using DataAccess.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Games.Queries.GetGameById
{
    public class GetGameByIdQueryHandler : IRequestHandler<GetGameByIdQuery, GetGameByIdVm>
    {
        private readonly GameDbContext _ctx;
        private readonly IMapper _mapper;

        public GetGameByIdQueryHandler(GameDbContext ctx, IMapper mapper) 
        {
            _ctx = ctx;
            _mapper = mapper;
        }

        public async Task<GetGameByIdVm> Handle(GetGameByIdQuery request, CancellationToken cancellationToken)
        {
            var game = await _ctx.Games.FirstOrDefaultAsync(x => x.Id == request.Id);

            return _mapper.Map<GetGameByIdVm>(game);
        }
    }
}
