using AutoMapper;
using DataAccess.Data;
using DataAccess.Games.Queries.GetGameById;
using DataAccess.Games.Queries.GetGamesList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class GameAutomapperProfile : Profile
    {
        public GameAutomapperProfile() 
        {
            CreateMap<Game, GetGameByIdVm>()
                .ForMember(
                    dst => dst.Id,
                    opt => opt.MapFrom(src => src.Id))
                .ForMember(
                    dst => dst.Name,
                    opt => opt.MapFrom(src => src.Name))
                .ForMember(
                    dst => dst.Description,
                    opt => opt.MapFrom(src => src.Description))
                .ForMember(
                    dst => dst.Price,
                    opt => opt.MapFrom(src => src.Price))
                .ForMember(
                    dst => dst.PublishingDate,
                    opt => opt.MapFrom(src => src.PublishingDate))
                .ForMember(
                    dst => dst.EditDate,
                    opt => opt.MapFrom(src => src.EditDate));

            CreateMap<Game, GameLookupDto>()
                .ForMember(
                    dst => dst.Id,
                    opt => opt.MapFrom(src => src.Id))
                .ForMember(
                    dst => dst.Name,
                    opt => opt.MapFrom(src => src.Name));
        }
    }
}
