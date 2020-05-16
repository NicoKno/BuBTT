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
    public class GameController : ControllerBase
    {
        private readonly ILogger<GameController> _logger;

        private readonly Game[] _games = new Game[]
        {
            new Game { GameId = 1, Name = "Warhammer 40k"},
            new Game { GameId = 2, Name = "Malifaux"},
            new Game { GameId = 2, Name = "Hordes"},
            new Game { GameId = 2, Name = "Warmachine"},
            new Game { GameId = 2, Name = "Kill Team"},
            new Game { GameId = 2, Name = "Shadespire"},
        };

        public GameController(ILogger<GameController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Game> Get()
        {
            return _games;
        }
    }
}
