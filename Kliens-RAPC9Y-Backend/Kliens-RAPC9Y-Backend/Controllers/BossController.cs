using Kliens_RAPC9Y_Backend.Data;
using Kliens_RAPC9Y_Backend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace Kliens_RAPC9Y_Backend.Controllers
{
    //[Authorize]
    [Route("[controller]")]
    [ApiController]
    public class BossController : ControllerBase
    {
        private ApiDbContext ctx;
        private readonly UserManager<AppUser> _userManager;
        private readonly IHubContext<NotificationHub> _hubContext;

        public BossController(ApiDbContext ctx, UserManager<AppUser> userManager, IHubContext<NotificationHub> hubContext)
        {
            this.ctx = ctx;
            _userManager = userManager;
            _hubContext = hubContext;
        }

        [HttpGet]
        public IEnumerable<Boss> GetBosses()
        {
            return ctx.Bosses;
        }

        [Authorize]
        [HttpGet("{name}")]
        public IActionResult GetBoss(string name)
        {
            var boss = ctx.Bosses.FirstOrDefault(t => t.Id == name);
            if (boss == null)
            {
                return NotFound(); // Return 404 if boss not found
            }

            return Ok(boss); // Return 200 with the boss entity
        }

        [Authorize]
        [HttpPost]
        public async void AddBoss([FromBody] Boss b)
        {
            b.Id = Guid.NewGuid().ToString();
            ctx.Bosses.Add(b);
            ctx.SaveChanges();
            await _hubContext.Clients.All.SendAsync("AddBoss", b);

        }

        [Authorize]
        [HttpPut]
        public async void EditBoss([FromBody] Boss b)
        {
            var old = ctx.Bosses.FirstOrDefault(t=>t.Id == b.Id);
            old.Game_Id = b.Game_Id;
            old.BossName = b.BossName;
            old.Hp = b.Hp;
            old.Souls = b.Souls;
            old.Location = b.Location;
            old.Defense = b.Defense;
            old.Image = b.Image;
            old.Description = b.Description;
            ctx.SaveChanges();
        }

        [Authorize]
        [HttpDelete("{name}")]
        public async void DeleteBoss(string name)
        {
            var old = ctx.Bosses.FirstOrDefault(t => t.Id == name);
            ctx.Bosses.Remove(old);
            ctx.SaveChanges();
            await _hubContext.Clients.All.SendAsync("DeleteBoss", name);
        }

        [HttpPost("{username}/{bossName}")]
        public async Task<IActionResult> DefeatBoss(string username, string bossName)
        {
            var user = _userManager.Users.FirstOrDefault(t => t.UserName == username);
            var boss = ctx.Bosses.FirstOrDefault(b => b.BossName == bossName);

            if (user == null || boss == null)
            {
                return NotFound();
            }

            user.DefeatedBosses += boss.BossName + ";";
            ctx.SaveChanges();
            await _hubContext.Clients.All.SendAsync("AddDefeatedBoss", user.DefeatedBosses);

            return Ok();
        }
    }
}
