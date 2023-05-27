using AutoMapper;
using BLL.Models;
using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AppMappingProfile : Profile
    {
        public AppMappingProfile()
        {
            CreateMap<UserModel, User>()
                .ForMember(userModel => userModel.FullName,
                opt => opt.MapFrom(user => user.FullName))
                .ForMember(userModel => userModel.Email,
                opt => opt.MapFrom(user => user.Email));


            CreateMap<User, UserModel>()
                .ForMember(user => user.FullName,
                opt => opt.MapFrom(userModel => userModel.FullName))
                .ForMember(user => user.Email,
                opt => opt.MapFrom(userModel => userModel.Email));
        }
    }
}
