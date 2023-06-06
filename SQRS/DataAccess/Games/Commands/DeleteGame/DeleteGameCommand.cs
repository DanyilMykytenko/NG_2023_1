using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Games.Commands.DeleteGame
{
    public class DeleteGameCommand : IRequest
    {
        public int Id { get; set; }
    }
}
