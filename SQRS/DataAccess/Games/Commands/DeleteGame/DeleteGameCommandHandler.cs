using DataAccess.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Games.Commands.DeleteGame
{
    public class DeleteGameCommandHandler : IRequestHandler<DeleteGameCommand>
    {
        private readonly GameDbContext _ctx;
        public DeleteGameCommandHandler(GameDbContext ctx) 
        {
            _ctx = ctx;
        }

        public async Task Handle(DeleteGameCommand request, CancellationToken cancellationToken)
        {
            var entity = await _ctx.Games.FirstOrDefaultAsync(x => x.Id == request.Id);

            if(entity is null)
            {
                //  S D E L O T - E X C E P T I O N
            }

            _ctx.Games.Remove(entity);
            await _ctx.SaveChangesAsync(cancellationToken);
        }
    }
}
