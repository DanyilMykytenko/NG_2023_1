using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UoFExample.DAL.Entities;
using UoFExample.DAL.Reposioties.Interfaces;
using UoFExample.DAL.UoF;

namespace UofExample.PL.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GamesController : ControllerBase
    {
        private IUnitOfWork _unitOfWork;
        
        public GamesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var repo = _unitOfWork.GetRepository<Game, IGameRepository>();

            return Ok(await repo.GetAllAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync()
        {
            var genre = new Genre
            {
                Id = Guid.NewGuid(),
                Name = "RPG"
            };
            
            var game = new Game
            {
                Name = "Skyrim",
                Desc = "Kill dovas",
                Genre = genre,
                GenreId = genre.Id
            };

            var result = await _unitOfWork.GetRepository<Game, IGameRepository>().AddAsync(game);

            await _unitOfWork.SaveAsync();
            
            return Ok(result);
        }
    }
}