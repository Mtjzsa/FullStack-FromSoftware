using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kliens_RAPC9Y_Backend.Migrations
{
    public partial class bossDescriptionAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "04f1d6de-e104-4c37-8e41-eecaff30bf42");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "18ad68da-9304-4feb-ac11-6047d65c4e0d");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "1d98abe8-067d-40d5-9c6b-3975c3395df2");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "21fa331b-5954-41fb-b562-27730cb1274b");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "58bdbf8d-934b-4a73-b3ab-cb7f46ef4c34");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "82f0b6a9-e802-407e-8c04-5e1933d8cfea");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "8ec60d2a-946d-4d22-971e-a9fc423e7342");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "92347543-2a10-40a1-8b0f-850d39fd20c0");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "b61c1f05-d89c-43d4-ae69-6e5d0fa00f0c");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "b7ba2f00-749b-4189-8209-f9b21b3993ff");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "c7145a87-1260-4ef1-a9a1-7e31a93aca74");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "d0bf53bf-eea8-4981-96fe-19e0f6993485");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "dbe98d21-8266-4a1d-b8c3-d79a0bdc3f12");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "ec1de4a3-39e8-4bd7-8f51-cbc167945cb7");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "ef62f043-14c6-4140-bc24-89161461a63c");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Bosses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Bosses",
                columns: new[] { "Id", "BossName", "Defense", "Description", "Game_Id", "Hp", "Image", "Location", "Souls" },
                values: new object[,]
                {
                    { "1ad79df4-3ae7-4bcf-a483-932443e5099a", "The Pursuer", 123, "", 4, 3500, "https://darksouls2.wiki.fextralife.com/file/Dark-Souls-2/pursuer.png", "Forest of Fallen Giants", 17000 },
                    { "2693f4b1-80c6-4b66-b2ba-906133eee594", "Nashandra", 135, "", 4, 8770, "https://darksouls2.wiki.fextralife.com/file/Dark-Souls-2/nashandra.png", "Throne of Want", 90000 },
                    { "28a28fc4-8133-4b05-bb2a-d7eca0a76841", "Pontiff Sulyvahn", 107, "", 5, 5106, "https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/pontiff_sulyvahn_trophy.PNG", "Irithyll of the Boreal Valley", 28000 },
                    { "354855a3-8f70-4c78-8f1b-44528b361c5e", "Leonine Misbegotten", 104, "", 1, 2198, "https://eldenring.wiki.fextralife.com/file/Elden-Ring/leonine_misbegotten_bosses_elden_ring_wiki_600px1.jpg", "Castle Morne", 3800 },
                    { "3a9dfd7d-dfe2-45c2-b966-84adbf34e057", "Isshin, the Sword Saint", 700, "", 6, 10000, "https://sekiroshadowsdietwice.wiki.fextralife.com/file/Sekiro-Shadows-Die-Twice/isshin-sword-saint-boss-sekiro-wiki-guide-300px.png", "Ashina Castle", 2000 },
                    { "49cbb513-a95e-488a-a99b-e1dca5f118a3", "Rennala, Queen of the Full Moon", 109, "", 1, 40000, "https://eldenring.wiki.fextralife.com/file/Elden-Ring/rennala_queen_of_the_full_moon_bosses_elden_ring_wiki_600px1-min.jpg", "Raya Lucaria Academy", 700 },
                    { "5aabf439-2265-4d7c-8d3f-91215ec8547b", "Genichiro Ashina", 600, "", 6, 10000, "https://sekiroshadowsdietwice.wiki.fextralife.com/file/Sekiro-Shadows-Die-Twice/genichiro-ashina-boss-sekiro-wiki-guide-300px.png", "Ashina Castle", 20000 },
                    { "5d4db694-6804-459d-9e2e-a4f72f7cfef2", "Gwyn, Lord of Cinder", 120, "", 3, 4250, "https://darksouls.wiki.fextralife.com/file/Dark-Souls/Boss_0024_Gwyn%20Lord%20of%20Cinder.jpg", "Kiln of the First Flame", 70000 },
                    { "705f060b-73d1-4481-9802-200c137f1015", "Margit the Fell Omen", 103, "Margit, the Fell Omen is a Great Enemy Boss in Elden Ring. This is an optional boss as players don't need to defeat him to advance in Elden Ring, though they do need to defeat Margit to advance to Stormveil Castle.\r\n\r\nMargit, the Fell Omen is found in Stormhill when players attempt to approach Stormveil Castle. A non-boss variant can be found later again when approaching a stationary enemy slightly southwest of the Outer Wall Battleground Site of Grace in the Capital Outskirts. Margit stands in the Tarnished's way to prevent them from approaching the Elden Ring, though his motivations are only explained in a later encounter.", 1, 4074, "https://eldenring.wiki.fextralife.com/file/Elden-Ring/margit-1-boss-elden-ring-wiki.jpg", "Stormveil Castle", 12000 },
                    { "854363df-3fd1-4cb5-ad53-c23f8ff142d9", "Red Wolf of Radagon", 107, "Red Wolf of Radagon is a Great Enemy Boss in Elden Ring. This giant red wolf wields sorceries and guards the found in the Grand Library of Raya Lucaria Academy. This is an optional boss as players don't need to defeat it to advance in Elden Ring, though they do need to defeat it to advance further in Raya Lucaria Academy and to achieve a certain ending.\r\n\r\nLesser Red Wolf of Radagon is the normal enemy form of this boss. Red Wolf of the Champion is another variant of this boss.", 1, 2204, "https://eldenring.wiki.fextralife.com/file/Elden-Ring/red-wolf-of-radagon-2-elden-ring-wiki-guide.jpg", "Raya Lucaria Academy", 14000 },
                    { "8b52d754-4a44-4b5e-be26-6312d6f3be0d", "Soul of Cinder", 150, "", 5, 10766, "https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/tumblr_o25lubbSXv1qzwtdlo1_1280.jpg", "Kiln of the First Flame", 100000 },
                    { "8cb272c6-afdb-48ba-9a56-51739b3a57fd", "Ornstein", 100, "", 3, 1642, "https://darksouls.wiki.fextralife.com/file/Dark-Souls/tumblr_lxlmomDlzY1qgjlhf.jpg", "Anor Londo", 50000 },
                    { "9a09899c-fc65-41d9-96ff-ff1047a796bb", "Father Gascoigne", 95, "", 2, 2031, "https://bloodborne.wiki.fextralife.com/file/Bloodborne/father_gascoigne_boss.jpg", "Central Yharnam", 1800 },
                    { "cb35a414-6096-4017-a88f-b5c07f92bd69", "Gehrman, The First Hunter", 150, "", 2, 14293, "https://bloodborne.wiki.fextralife.com/file/Bloodborne/gehrman_boss.jpg", "Hunter's Dream", 128000 },
                    { "e3ab6da6-81ec-4bfc-adf6-b120b4f7ed78", "Godrick the Grafted", 105, "Godrick the Grafted, also known as Godrick the Golden, is a Demigod Boss in Elden Ring. This Elden Ring Godrick the Grafted Guide features boss locations, tips, strategies and videos on how to defeat Godrick easily, as well as boss stats and lore for Godrick. Bosses are unique and challenging Enemies that can be encountered all over the Lands Between. Shardbearers drop their own unique Great Rune and Remembrance capable of being transformed into powerful Weapons, Spells, Ashes of War, and Talismans for the player.\r\n\r\nGodrick the Grafted is the ruler of Stormveil Castle, and is one of the first demigods and shardbearers that players can fight. He is a descendant of Godfrey and thus born of the golden lineage, but Gideon and Kenneth Haight believe him to be weak and unworthy to rule. Much of Godrick's power comes from the arms and legs of soldiers he's grafted onto himself, and especially the dragon head grafted onto his left arm during the second phase of his fight. His knights and soldiers wear armor that bears emblems of the golden lineage: a two-headed war-axe and the beast regent, Serosh.\r\n\r\nGodrick is an optional boss, and doesn't need to be defeated in order to advance in Elden Ring. You can advance to Liurnia of the Lakes without defeating him by following the path north from Stormhill Shack, then dropping down to the west from the broken bridge and walking along the outside of the castle. However, Godrick is a shardbearer, and two of the five available shardbearers must be defeated before entering Leyndell, Royal Capital.", 1, 6080, "https://eldenring.wiki.fextralife.com/file/Elden-Ring/godrick_the_grafted_bosses_elden_ring_wiki_600px1-min.jpg", "Stormveil Castle", 20000 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "1ad79df4-3ae7-4bcf-a483-932443e5099a");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "2693f4b1-80c6-4b66-b2ba-906133eee594");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "28a28fc4-8133-4b05-bb2a-d7eca0a76841");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "354855a3-8f70-4c78-8f1b-44528b361c5e");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "3a9dfd7d-dfe2-45c2-b966-84adbf34e057");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "49cbb513-a95e-488a-a99b-e1dca5f118a3");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "5aabf439-2265-4d7c-8d3f-91215ec8547b");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "5d4db694-6804-459d-9e2e-a4f72f7cfef2");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "705f060b-73d1-4481-9802-200c137f1015");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "854363df-3fd1-4cb5-ad53-c23f8ff142d9");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "8b52d754-4a44-4b5e-be26-6312d6f3be0d");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "8cb272c6-afdb-48ba-9a56-51739b3a57fd");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "9a09899c-fc65-41d9-96ff-ff1047a796bb");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "cb35a414-6096-4017-a88f-b5c07f92bd69");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "e3ab6da6-81ec-4bfc-adf6-b120b4f7ed78");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Bosses");

            migrationBuilder.InsertData(
                table: "Bosses",
                columns: new[] { "Id", "BossName", "Defense", "Game_Id", "Hp", "Image", "Location", "Souls" },
                values: new object[,]
                {
                    { "04f1d6de-e104-4c37-8e41-eecaff30bf42", "Father Gascoigne", 95, 2, 2031, "https://bloodborne.wiki.fextralife.com/file/Bloodborne/father_gascoigne_boss.jpg", "Central Yharnam", 1800 },
                    { "18ad68da-9304-4feb-ac11-6047d65c4e0d", "Rennala, Queen of the Full Moon", 109, 1, 40000, "https://eldenring.wiki.fextralife.com/file/Elden-Ring/rennala_queen_of_the_full_moon_bosses_elden_ring_wiki_600px1-min.jpg", "Raya Lucaria Academy", 700 },
                    { "1d98abe8-067d-40d5-9c6b-3975c3395df2", "Margit the Fell Omen", 103, 1, 4074, "https://eldenring.wiki.fextralife.com/file/Elden-Ring/margit-1-boss-elden-ring-wiki.jpg", "Stormveil Castle", 12000 },
                    { "21fa331b-5954-41fb-b562-27730cb1274b", "Gwyn, Lord of Cinder", 120, 3, 4250, "https://darksouls.wiki.fextralife.com/file/Dark-Souls/Boss_0024_Gwyn%20Lord%20of%20Cinder.jpg", "Kiln of the First Flame", 70000 },
                    { "58bdbf8d-934b-4a73-b3ab-cb7f46ef4c34", "Pontiff Sulyvahn", 107, 5, 5106, "https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/pontiff_sulyvahn_trophy.PNG", "Irithyll of the Boreal Valley", 28000 },
                    { "82f0b6a9-e802-407e-8c04-5e1933d8cfea", "The Pursuer", 123, 4, 3500, "https://darksouls2.wiki.fextralife.com/file/Dark-Souls-2/pursuer.png", "Forest of Fallen Giants", 17000 },
                    { "8ec60d2a-946d-4d22-971e-a9fc423e7342", "Ornstein", 100, 3, 1642, "https://darksouls.wiki.fextralife.com/file/Dark-Souls/tumblr_lxlmomDlzY1qgjlhf.jpg", "Anor Londo", 50000 },
                    { "92347543-2a10-40a1-8b0f-850d39fd20c0", "Nashandra", 135, 4, 8770, "https://darksouls2.wiki.fextralife.com/file/Dark-Souls-2/nashandra.png", "Throne of Want", 90000 },
                    { "b61c1f05-d89c-43d4-ae69-6e5d0fa00f0c", "Leonine Misbegotten", 104, 1, 2198, "https://eldenring.wiki.fextralife.com/file/Elden-Ring/leonine_misbegotten_bosses_elden_ring_wiki_600px1.jpg", "Castle Morne", 3800 },
                    { "b7ba2f00-749b-4189-8209-f9b21b3993ff", "Soul of Cinder", 150, 5, 10766, "https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/tumblr_o25lubbSXv1qzwtdlo1_1280.jpg", "Kiln of the First Flame", 100000 },
                    { "c7145a87-1260-4ef1-a9a1-7e31a93aca74", "Isshin, the Sword Saint", 700, 6, 10000, "https://sekiroshadowsdietwice.wiki.fextralife.com/file/Sekiro-Shadows-Die-Twice/isshin-sword-saint-boss-sekiro-wiki-guide-300px.png", "Ashina Castle", 2000 },
                    { "d0bf53bf-eea8-4981-96fe-19e0f6993485", "Red Wolf of Radagon", 107, 1, 2204, "https://eldenring.wiki.fextralife.com/file/Elden-Ring/red-wolf-of-radagon-2-elden-ring-wiki-guide.jpg", "Raya Lucaria Academy", 14000 },
                    { "dbe98d21-8266-4a1d-b8c3-d79a0bdc3f12", "Godrick the Grafted", 105, 1, 6080, "https://eldenring.wiki.fextralife.com/file/Elden-Ring/godrick_the_grafted_bosses_elden_ring_wiki_600px1-min.jpg", "Stormveil Castle", 20000 },
                    { "ec1de4a3-39e8-4bd7-8f51-cbc167945cb7", "Genichiro Ashina", 600, 6, 10000, "https://sekiroshadowsdietwice.wiki.fextralife.com/file/Sekiro-Shadows-Die-Twice/genichiro-ashina-boss-sekiro-wiki-guide-300px.png", "Ashina Castle", 20000 },
                    { "ef62f043-14c6-4140-bc24-89161461a63c", "Gehrman, The First Hunter", 150, 2, 14293, "https://bloodborne.wiki.fextralife.com/file/Bloodborne/gehrman_boss.jpg", "Hunter's Dream", 128000 }
                });
        }
    }
}
