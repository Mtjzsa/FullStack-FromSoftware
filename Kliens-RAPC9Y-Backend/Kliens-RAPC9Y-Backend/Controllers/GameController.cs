using Kliens_RAPC9Y_Backend.Data;
using Kliens_RAPC9Y_Backend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace Kliens_RAPC9Y_Backend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        ApiDbContext ctx;
        private readonly IHubContext<NotificationHub> _hubContext;

        public GameController(ApiDbContext ctx, IHubContext<NotificationHub> hubContext)
        {
            this.ctx = ctx;
            _hubContext = hubContext;
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
            var old = ctx.Games.FirstOrDefault(t => t.Id == g.Id);
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
