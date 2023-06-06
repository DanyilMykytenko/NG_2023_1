using DataAccess.Data;
using DataAccess.Infrastructure;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Games.Commands.CreateGame
{
    public class CreateGameCommandHandler : IRequestHandler<CreateGameCommand, int>
    {
        private readonly GameDbContext _ctx;

        public CreateGameCommandHandler(GameDbContext ctx) 
        {
            _ctx = ctx;
        }

        public async Task<int> Handle(CreateGameCommand request, CancellationToken cancellationToken)
        {
            var game = new Game
            {
                Name = request.Name,
                Description = request.Description,
                Price = request.Price,
                PublishingDate = DateTime.UtcNow,
                EditDate = null
            };

            await _ctx.Games.AddAsync(game, cancellationToken);
            await _ctx.SaveChangesAsync(cancellationToken);

            return game.Id;
        }
    }
}
