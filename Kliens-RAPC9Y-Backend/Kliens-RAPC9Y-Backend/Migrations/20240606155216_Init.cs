using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kliens_RAPC9Y_Backend.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<int>(type: "int", nullable: false),
                    GameCover = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bosses",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Game_Id = table.Column<int>(type: "int", nullable: false),
                    BossName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hp = table.Column<int>(type: "int", nullable: false),
                    Souls = table.Column<int>(type: "int", nullable: false),
                    Defense = table.Column<int>(type: "int", nullable: false),
                    Defeated = table.Column<bool>(type: "bit", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bosses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bosses_Games_Game_Id",
                        column: x => x.Game_Id,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "Admin", "ADMIN" },
                    { "2", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "GameCover", "GameName", "ReleaseDate" },
                values: new object[,]
                {
                    { 1, "https://media.fromsoftware.jp/fromsoftware/ww/static/img/products/title_img/high/img_titlearchive_105.jpg", "Elden Ring", 2022 },
                    { 2, "https://media.fromsoftware.jp/fromsoftware/ww/static/img/products/title_img/high/img_titlearchive_94.jpg", "Bloodborne", 2015 },
                    { 3, "https://media.fromsoftware.jp/fromsoftware/ww/static/img/products/title_img/high/img_titlearchive_86.jpg", "Dark Souls", 2011 },
                    { 4, "https://media.fromsoftware.jp/fromsoftware/ww/static/img/products/title_img/high/img_titlearchive_92.jpg", "Dark Souls II", 2014 },
                    { 5, "https://media.fromsoftware.jp/fromsoftware/ww/static/img/products/title_img/high/img_titlearchive_97.jpg", "Dark Souls III", 2016 },
                    { 6, "https://media.fromsoftware.jp/fromsoftware/ww/static/img/products/title_img/high/img_titlearchive_102.jpg", "Sekiro: Shadows Die Twice", 2019 }
                });

            migrationBuilder.InsertData(
                table: "Bosses",
                columns: new[] { "Id", "BossName", "Defeated", "Defense", "Game_Id", "Hp", "Image", "Location", "Souls" },
                values: new object[,]
                {
                    { "14bd17fd-1dc2-4aa4-997f-a6ab1d6ca8d3", "Godrick the Grafted", true, 105, 1, 6080, "https://eldenring.wiki.fextralife.com/file/Elden-Ring/godrick_the_grafted_bosses_elden_ring_wiki_600px1-min.jpg", "Stormveil Castle", 20000 },
                    { "16addf84-ccd0-4a19-94e3-982274c4f0e0", "Soul of Cinder", false, 150, 5, 10766, "https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/tumblr_o25lubbSXv1qzwtdlo1_1280.jpg", "Kiln of the First Flame", 100000 },
                    { "1969e88d-3547-4b3a-8982-b845791c02f1", "The Pursuer", false, 123, 4, 3500, "https://darksouls2.wiki.fextralife.com/file/Dark-Souls-2/pursuer.png", "Forest of Fallen Giants", 17000 },
                    { "31176dc7-36df-4d39-bbde-eb48b63d102a", "Leonine Misbegotten", true, 104, 1, 2198, "https://eldenring.wiki.fextralife.com/file/Elden-Ring/leonine_misbegotten_bosses_elden_ring_wiki_600px1.jpg", "Castle Morne", 3800 },
                    { "345e756a-250d-4d19-9061-6184f0002e40", "Red Wolf of Radagon", false, 107, 1, 2204, "https://eldenring.wiki.fextralife.com/file/Elden-Ring/red-wolf-of-radagon-2-elden-ring-wiki-guide.jpg", "Raya Lucaria Academy", 14000 },
                    { "544e69d9-a53f-4cc7-aad3-384fb1cc1808", "Gwyn, Lord of Cinder", false, 120, 3, 4250, "https://darksouls.wiki.fextralife.com/file/Dark-Souls/Boss_0024_Gwyn%20Lord%20of%20Cinder.jpg", "Kiln of the First Flame", 70000 },
                    { "59c0f7c1-b77f-4d66-b0fd-da7a45b8ad04", "Isshin, the Sword Saint", false, 700, 6, 10000, "https://sekiroshadowsdietwice.wiki.fextralife.com/file/Sekiro-Shadows-Die-Twice/isshin-sword-saint-boss-sekiro-wiki-guide-300px.png", "Ashina Castle", 2000 },
                    { "63c10eb7-8fb0-4270-9e97-0f55f2e042bc", "Rennala, Queen of the Full Moon", false, 109, 1, 40000, "https://eldenring.wiki.fextralife.com/file/Elden-Ring/rennala_queen_of_the_full_moon_bosses_elden_ring_wiki_600px1-min.jpg", "Raya Lucaria Academy", 700 },
                    { "6adde697-9787-48f9-834c-1277caa29824", "Pontiff Sulyvahn", false, 107, 5, 5106, "https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/pontiff_sulyvahn_trophy.PNG", "Irithyll of the Boreal Valley", 28000 },
                    { "70bd01e1-29ca-451c-b17b-1b6d7efb6b75", "Nashandra", false, 135, 4, 8770, "https://darksouls2.wiki.fextralife.com/file/Dark-Souls-2/nashandra.png", "Throne of Want", 90000 },
                    { "8e05559e-ca89-4224-9802-e56cb7f670c9", "Gehrman, The First Hunter", false, 150, 2, 14293, "https://bloodborne.wiki.fextralife.com/file/Bloodborne/gehrman_boss.jpg", "Hunter's Dream", 128000 },
                    { "b742202c-79bc-4a89-90a1-52be12db3a9d", "Ornstein", false, 100, 3, 1642, "https://darksouls.wiki.fextralife.com/file/Dark-Souls/tumblr_lxlmomDlzY1qgjlhf.jpg", "Anor Londo", 50000 },
                    { "dec83cbc-5ec9-46e4-ac85-230c3d03fc43", "Father Gascoigne", false, 95, 2, 2031, "https://bloodborne.wiki.fextralife.com/file/Bloodborne/father_gascoigne_boss.jpg", "Central Yharnam", 1800 },
                    { "ec30e37b-6384-4b33-9ed6-93e217a4fbf3", "Margit the Fell Omen", true, 103, 1, 4074, "https://eldenring.wiki.fextralife.com/file/Elden-Ring/margit-1-boss-elden-ring-wiki.jpg", "Stormveil Castle", 12000 },
                    { "f8591bf3-8dea-4c56-bee0-3475b0f0a208", "Genichiro Ashina", false, 600, 6, 10000, "https://sekiroshadowsdietwice.wiki.fextralife.com/file/Sekiro-Shadows-Die-Twice/genichiro-ashina-boss-sekiro-wiki-guide-300px.png", "Ashina Castle", 20000 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Bosses_Game_Id",
                table: "Bosses",
                column: "Game_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Bosses");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
