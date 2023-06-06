using AutoMapper;
using BLL.Models;
using DAL.Entity;
using DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task AddUser(UserModel user)
        {
            var mapped = _mapper.Map<User>(user);
            await _userRepository.AddAsync(mapped);
        }

        public async Task DeleteUser(int id)
        {
            await _userRepository.DeleteAsync(id);
        }
    }
}
