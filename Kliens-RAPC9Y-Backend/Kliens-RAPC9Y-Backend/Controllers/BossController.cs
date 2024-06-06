using Kliens_RAPC9Y_Backend.Data;
using Kliens_RAPC9Y_Backend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kliens_RAPC9Y_Backend.Controllers
{
    //[Authorize]
    [Route("[controller]")]
    [ApiController]
    public class BossController : ControllerBase
    {
        ApiDbContext ctx;

        public BossController(ApiDbContext ctx)
        {
            this.ctx = ctx;
        }

        [HttpGet]
        public IEnumerable<Boss> GetBosses()
        {
            return ctx.Bosses;
        }


        [HttpGet("{name}")]
        public Boss? GetBoss(string name)
        {
            return ctx.Bosses.FirstOrDefault(t => t.BossName == name);
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
            old.BossName = b.BossName;
            old.Hp = b.Hp;
            old.Souls = b.Souls;
            old.Location = b.Location;
            old.Defense = b.Defense;
            old.Defeated = b.Defeated;
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
    }
}
