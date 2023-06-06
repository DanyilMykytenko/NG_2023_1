using DataAccess.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Games.Commands.UpdateGame
{
    public class UpdateGameCommandHandler : IRequestHandler<UpdateGameCommand>
    {
        private readonly GameDbContext _ctx;

        public UpdateGameCommandHandler(GameDbContext ctx) 
        {
            _ctx = ctx;
        }
        public async Task Handle(UpdateGameCommand request, CancellationToken cancellationToken)
        {
            var entity = await _ctx.Games.FirstOrDefaultAsync(x => x.Id == request.Id);

            if (entity is null)
            {
                //  S D E L O T - E X C E P T I O N
            }

            entity.Name = request.Name;
            entity.Description = request.Description;
            entity.Price = request.Price;
            entity.EditDate = DateTime.UtcNow;

            await _ctx.SaveChangesAsync(cancellationToken);
        }
    }
}
