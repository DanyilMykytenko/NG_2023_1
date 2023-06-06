using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Games.Queries.GetGameById
{
    public class GetGameByIdVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public DateTime PublishingDate { get; set; }
        public DateTime? EditDate { get; set; }
    }
}
