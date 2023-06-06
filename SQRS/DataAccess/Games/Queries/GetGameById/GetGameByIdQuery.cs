using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Games.Queries.GetGameById
{
    public class GetGameByIdQuery : IRequest<GetGameByIdVm>
    {
        public int Id { get; set; }
    }
}
