using BuBTT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BuBTT.Server.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class GamesController : ControllerBase
    {
        private readonly ILogger<GamesController> _logger;

        private readonly Game[] _games = new Game[]
        {
            new Game { GameId = 1, Name = "Warhammer 40k"},
            new Game { GameId = 2, Name = "Malifaux"},
            new Game { GameId = 3, Name = "Hordes"},
            new Game { GameId = 4, Name = "Warmachine"},
            new Game { GameId = 5, Name = "Kill Team"},
            new Game { GameId = 6, Name = "Shadespire"},
        };

        public GamesController(ILogger<GamesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Game> Get()
        {
            return _games;
        }

        [HttpGet]
        [Route("Games/{id}")]
        public Game GetById([FromRoute]int id)
        {
            return _games.FirstOrDefault(g => g.GameId == id);
        }
    }
}
