using Kliens_RAPC9Y_Backend.Data;
using Kliens_RAPC9Y_Backend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Kliens_RAPC9Y_Backend.Controllers
{
    //[Authorize]
    [Route("[controller]")]
    [ApiController]
    public class BossController : ControllerBase
    {
        private ApiDbContext ctx;
        private readonly UserManager<AppUser> _userManager;

        public BossController(ApiDbContext ctx, UserManager<AppUser> userManager)
        {
            this.ctx = ctx;
            _userManager = userManager;
        }

        [HttpGet]
        public IEnumerable<Boss> GetBosses()
        {
            return ctx.Bosses;
        }


        [HttpGet("{name}")]
        public IActionResult GetBoss(string name)
        {
            var boss = ctx.Bosses.FirstOrDefault(t => t.BossName == name);
            if (boss == null)
            {
                return NotFound(); // Return 404 if boss not found
            }

            return Ok(boss); // Return 200 with the boss entity
        }

        [HttpPost]
        public void AddBoss([FromBody] Boss b)
        {
            ctx.Bosses.Add(b);
            ctx.SaveChanges();
        }

        [HttpPut]
        public void EditBoss([FromBody] Boss b)
        {
            var old = ctx.Bosses.FirstOrDefault(t=>t.BossName == b.BossName);
            old.Game_Id = b.Game_Id;
            old.BossName = b.BossName;
            old.Hp = b.Hp;
            old.Souls = b.Souls;
            old.Location = b.Location;
            old.Defense = b.Defense;
            old.Image = b.Image;
            ctx.SaveChanges();
        }

        [HttpDelete("{name}")]
        public void DeleteBoss(string name)
        {
            var old = ctx.Bosses.FirstOrDefault(t => t.BossName == name);
            ctx.Bosses.Remove(old);
            ctx.SaveChanges();
        }

        //[Authorize]
        [HttpPost("{userName}/defeat/{bossName}")]
        public IActionResult DefeatBoss(string userName, string bossName)
        {
            var user = _userManager.Users.FirstOrDefault(t => t.UserName == userName);
            var boss = ctx.Bosses.FirstOrDefault(b => b.BossName == bossName);

            if (user == null || boss == null)
            {
                return NotFound();
            }

            user.DefeatedBosses += boss.BossName + ";";
            ctx.SaveChanges();

            return Ok();
        }
    }
}
