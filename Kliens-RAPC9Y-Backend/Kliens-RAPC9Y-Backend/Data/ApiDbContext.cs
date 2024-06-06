using Kliens_RAPC9Y_Backend.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Kliens_RAPC9Y_Backend.Data
{
    public class ApiDbContext : IdentityDbContext<AppUser>
    {

        public ApiDbContext(DbContextOptions<ApiDbContext> opt) : base(opt)
        {
            
        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Boss> Bosses { get; set; }
        public DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData
            (
                new { Id = "1", Name="Admin", NormalizedName = "ADMIN"},
                new { Id = "2", Name="User", NormalizedName = "USER"}
            );

            builder.Entity<Boss>()
                .HasOne(t => t.Game)
                .WithMany(t=> t.Bosses)
                .HasForeignKey(t => t.Game_Id)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(builder);


            builder.Entity<Game>().HasData(new Game[]
            {
                new Game { Id = 1, GameName = "Elden Ring", ReleaseDate= 2022, GameCover="https://media.fromsoftware.jp/fromsoftware/ww/static/img/products/title_img/high/img_titlearchive_105.jpg" },
                new Game { Id = 2, GameName = "Bloodborne", ReleaseDate= 2015, GameCover="https://media.fromsoftware.jp/fromsoftware/ww/static/img/products/title_img/high/img_titlearchive_94.jpg" },
                new Game { Id = 3, GameName = "Dark Souls", ReleaseDate= 2011, GameCover="https://media.fromsoftware.jp/fromsoftware/ww/static/img/products/title_img/high/img_titlearchive_86.jpg" },
                new Game { Id = 4, GameName = "Dark Souls II", ReleaseDate= 2014, GameCover="https://media.fromsoftware.jp/fromsoftware/ww/static/img/products/title_img/high/img_titlearchive_92.jpg" },
                new Game { Id = 5, GameName = "Dark Souls III", ReleaseDate= 2016, GameCover="https://media.fromsoftware.jp/fromsoftware/ww/static/img/products/title_img/high/img_titlearchive_97.jpg" },
                new Game { Id = 6, GameName = "Sekiro: Shadows Die Twice", ReleaseDate= 2019, GameCover="https://media.fromsoftware.jp/fromsoftware/ww/static/img/products/title_img/high/img_titlearchive_102.jpg" }
            }
            
            );

            builder.Entity<Boss>().HasData(new Boss[]
            {
                //Elden ring bosses
                new Boss { Game_Id = 1, BossName = "Margit the Fell Omen", Location = "Stormveil Castle", Hp = 4074, Souls = 12000, Defense =103, Defeated = true, Image = "https://eldenring.wiki.fextralife.com/file/Elden-Ring/margit-1-boss-elden-ring-wiki.jpg" },
                new Boss { Game_Id = 1, BossName = "Godrick the Grafted", Location = "Stormveil Castle", Hp = 6080, Souls = 20000, Defense = 105, Defeated = true, Image = "https://eldenring.wiki.fextralife.com/file/Elden-Ring/godrick_the_grafted_bosses_elden_ring_wiki_600px1-min.jpg" },
                new Boss { Game_Id = 1, BossName = "Red Wolf of Radagon", Location = "Raya Lucaria Academy", Hp = 2204, Souls = 14000, Defense = 107, Defeated = false, Image = "https://eldenring.wiki.fextralife.com/file/Elden-Ring/red-wolf-of-radagon-2-elden-ring-wiki-guide.jpg" },
                new Boss { Game_Id = 1, BossName = "Rennala, Queen of the Full Moon", Location = "Raya Lucaria Academy", Hp = 40000, Souls = 700, Defense = 109, Defeated = false, Image = "https://eldenring.wiki.fextralife.com/file/Elden-Ring/rennala_queen_of_the_full_moon_bosses_elden_ring_wiki_600px1-min.jpg" },
                new Boss { Game_Id = 1, BossName = "Leonine Misbegotten", Location = "Castle Morne", Hp = 2198, Souls = 3800, Defense = 104, Defeated = true, Image = "https://eldenring.wiki.fextralife.com/file/Elden-Ring/leonine_misbegotten_bosses_elden_ring_wiki_600px1.jpg" },

                // Bloodborne Bosses
                new Boss { Game_Id = 2, BossName = "Father Gascoigne", Location = "Central Yharnam", Hp = 2031, Souls = 1800, Defense = 95, Defeated = false, Image = "https://bloodborne.wiki.fextralife.com/file/Bloodborne/father_gascoigne_boss.jpg" },
                new Boss { Game_Id = 2, BossName = "Gehrman, The First Hunter", Location = "Hunter's Dream", Hp = 14293, Souls = 128000, Defense = 150, Defeated = false, Image = "https://bloodborne.wiki.fextralife.com/file/Bloodborne/gehrman_boss.jpg" },
                
                // Dark Souls Bosses
                new Boss{ Game_Id = 3, BossName = "Gwyn, Lord of Cinder", Location = "Kiln of the First Flame", Hp = 4250, Souls = 70000, Defense = 120, Defeated = false, Image = "https://darksouls.wiki.fextralife.com/file/Dark-Souls/Boss_0024_Gwyn%20Lord%20of%20Cinder.jpg" },
                new Boss{ Game_Id = 3, BossName = "Ornstein", Location = "Anor Londo", Hp = 1642, Souls = 50000, Defense = 100, Defeated = false, Image = "https://darksouls.wiki.fextralife.com/file/Dark-Souls/tumblr_lxlmomDlzY1qgjlhf.jpg" },

                // Dark Souls II Bosses
                new Boss { Game_Id = 4, BossName = "Nashandra", Location = "Throne of Want", Hp = 8770, Souls = 90000, Defense = 135, Defeated = false, Image = "https://darksouls2.wiki.fextralife.com/file/Dark-Souls-2/nashandra.png" },
                new Boss { Game_Id = 4, BossName = "The Pursuer", Location = "Forest of Fallen Giants", Hp = 3500, Souls = 17000, Defense = 123, Defeated = false, Image = "https://darksouls2.wiki.fextralife.com/file/Dark-Souls-2/pursuer.png" },
                
                // Dark Souls III Bosses
                new Boss { Game_Id = 5, BossName = "Soul of Cinder", Location = "Kiln of the First Flame", Hp = 10766, Souls = 100000, Defense = 150, Defeated = false, Image = "https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/tumblr_o25lubbSXv1qzwtdlo1_1280.jpg" },
                new Boss { Game_Id = 5, BossName = "Pontiff Sulyvahn", Location = "Irithyll of the Boreal Valley", Hp = 5106, Souls = 28000, Defense = 107, Defeated = false, Image = "https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/pontiff_sulyvahn_trophy.PNG" },
                
                // Sekiro: Shadows Die Twice Bosses
                new Boss { Game_Id = 6, BossName = "Isshin, the Sword Saint", Location = "Ashina Castle", Hp = 10000, Souls = 2000, Defense = 700, Defeated = false, Image = "https://sekiroshadowsdietwice.wiki.fextralife.com/file/Sekiro-Shadows-Die-Twice/isshin-sword-saint-boss-sekiro-wiki-guide-300px.png" },
                new Boss { Game_Id = 6, BossName = "Genichiro Ashina", Location = "Ashina Castle", Hp = 10000, Souls = 20000, Defense = 600, Defeated = false, Image = "https://sekiroshadowsdietwice.wiki.fextralife.com/file/Sekiro-Shadows-Die-Twice/genichiro-ashina-boss-sekiro-wiki-guide-300px.png" }
            });




        }
    }
}
