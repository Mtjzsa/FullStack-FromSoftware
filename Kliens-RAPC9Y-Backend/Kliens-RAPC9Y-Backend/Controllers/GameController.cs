using Kliens_RAPC9Y_Backend.Data;
using Kliens_RAPC9Y_Backend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kliens_RAPC9Y_Backend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        ApiDbContext ctx;

        public GameController(ApiDbContext ctx)
        {
            this.ctx = ctx;
        }

        [HttpGet]
        public IEnumerable<Game> GetGames()
        {
            return ctx.Games;
        }

        [Authorize]
        [HttpGet("{name}")]
        public Game? GetGame(string name)
        {
            return ctx.Games.FirstOrDefault(t => t.GameName == name);
        }

        [Authorize]
        [HttpPost]
        public void AddGame([FromBody] Game g)
        {
            ctx.Games.Add(g);
            ctx.SaveChanges();
        }

        [Authorize]
        [HttpPut]
        public void EditGame([FromBody] Game g)
        {
            var old = ctx.Games.FirstOrDefault(t => t.GameName == g.GameName);
            old.GameName = g.GameName;
            old.ReleaseDate = g.ReleaseDate;
            old.GameCover = g.GameCover;
            old.GameDescription = g.GameDescription;
            ctx.SaveChanges();
        }

        [Authorize]
        [HttpDelete("{name}")]
        public void DeleteGame(string name)
        {
            var old = ctx.Games.FirstOrDefault(t => t.GameName == name);
            ctx.Games.Remove(old);
            ctx.SaveChanges();
        }
    }
}
