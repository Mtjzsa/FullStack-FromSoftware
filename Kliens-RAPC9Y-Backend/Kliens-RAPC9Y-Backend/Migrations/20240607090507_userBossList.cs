using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kliens_RAPC9Y_Backend.Migrations
{
    public partial class userBossList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "01cc89b8-15dc-4086-bb22-bfa56c92a20a");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "0ac3e438-c928-437f-8142-c3a0ac0e7b70");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "0b3f3972-c11e-47ca-ad16-bfee4cb93955");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "1103d44d-7057-48be-8690-49805b6015d9");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "25a97615-e014-419e-a681-331790ce1876");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "294db89d-18f8-4f7c-83fb-0c5004d18d21");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "29936042-ca86-4886-ab9f-dd616a5020f9");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "2d1c5d0a-52da-49ca-a9f3-27397719edc2");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "5d4a0303-db2e-46b8-a7d4-24e1e53e28f7");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "63b0390d-dec2-4246-a85a-ad22e9395a93");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "aa0abbc1-5208-443a-b2b7-70627ac0e617");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "dbb43a6d-6fd4-4405-b4d8-fc358faf0806");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "de68ca0f-ed5b-47e9-b2aa-67668b2b3a10");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "ec700e4c-7add-4518-b4eb-4e5a076ba595");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "f465471a-c192-4066-8e61-6d06048c4f87");

            migrationBuilder.InsertData(
                table: "Bosses",
                columns: new[] { "Id", "BossName", "Defeated", "Defense", "Game_Id", "Hp", "Image", "Location", "Souls" },
                values: new object[,]
                {
                    { "04d88467-5cd2-4e99-bc39-7db9a8e8c22e", "Soul of Cinder", false, 150, 5, 10766, "https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/tumblr_o25lubbSXv1qzwtdlo1_1280.jpg", "Kiln of the First Flame", 100000 },
                    { "0a62d641-a5c5-4109-82da-8b748b5e329a", "Nashandra", false, 135, 4, 8770, "https://darksouls2.wiki.fextralife.com/file/Dark-Souls-2/nashandra.png", "Throne of Want", 90000 },
                    { "28d185da-367b-4441-ac88-f3c28f581fd7", "Rennala, Queen of the Full Moon", false, 109, 1, 40000, "https://eldenring.wiki.fextralife.com/file/Elden-Ring/rennala_queen_of_the_full_moon_bosses_elden_ring_wiki_600px1-min.jpg", "Raya Lucaria Academy", 700 },
                    { "32b177e1-1932-431d-bd78-1aa6944c58af", "Gwyn, Lord of Cinder", false, 120, 3, 4250, "https://darksouls.wiki.fextralife.com/file/Dark-Souls/Boss_0024_Gwyn%20Lord%20of%20Cinder.jpg", "Kiln of the First Flame", 70000 },
                    { "339d555b-2ca1-4d59-a8a7-e7b40589d0c0", "Ornstein", false, 100, 3, 1642, "https://darksouls.wiki.fextralife.com/file/Dark-Souls/tumblr_lxlmomDlzY1qgjlhf.jpg", "Anor Londo", 50000 },
                    { "39fe4b5e-29ef-4855-ae9f-c5a3f84207bf", "The Pursuer", false, 123, 4, 3500, "https://darksouls2.wiki.fextralife.com/file/Dark-Souls-2/pursuer.png", "Forest of Fallen Giants", 17000 },
                    { "3e4eb83b-8ae7-470a-afc4-759e452f1c0a", "Red Wolf of Radagon", false, 107, 1, 2204, "https://eldenring.wiki.fextralife.com/file/Elden-Ring/red-wolf-of-radagon-2-elden-ring-wiki-guide.jpg", "Raya Lucaria Academy", 14000 },
                    { "498e0829-386a-4c75-ae5c-b7e288e03ed1", "Leonine Misbegotten", true, 104, 1, 2198, "https://eldenring.wiki.fextralife.com/file/Elden-Ring/leonine_misbegotten_bosses_elden_ring_wiki_600px1.jpg", "Castle Morne", 3800 },
                    { "601016d4-3bad-4bd4-9e60-31dc09f5e521", "Isshin, the Sword Saint", false, 700, 6, 10000, "https://sekiroshadowsdietwice.wiki.fextralife.com/file/Sekiro-Shadows-Die-Twice/isshin-sword-saint-boss-sekiro-wiki-guide-300px.png", "Ashina Castle", 2000 },
                    { "82c65bc2-ae08-4158-b158-5092e7f2e21a", "Father Gascoigne", false, 95, 2, 2031, "https://bloodborne.wiki.fextralife.com/file/Bloodborne/father_gascoigne_boss.jpg", "Central Yharnam", 1800 },
                    { "8f1ce319-dd0f-468f-9461-ad9dbd9de136", "Margit the Fell Omen", true, 103, 1, 4074, "https://eldenring.wiki.fextralife.com/file/Elden-Ring/margit-1-boss-elden-ring-wiki.jpg", "Stormveil Castle", 12000 },
                    { "8f8e444d-6a78-4b9c-bf26-d224491ad799", "Genichiro Ashina", false, 600, 6, 10000, "https://sekiroshadowsdietwice.wiki.fextralife.com/file/Sekiro-Shadows-Die-Twice/genichiro-ashina-boss-sekiro-wiki-guide-300px.png", "Ashina Castle", 20000 },
                    { "90ee3f72-e5e8-4c3b-8010-ea2c69e004fa", "Pontiff Sulyvahn", false, 107, 5, 5106, "https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/pontiff_sulyvahn_trophy.PNG", "Irithyll of the Boreal Valley", 28000 },
                    { "cdd68fd3-fa61-4fb4-8b93-e8596788509d", "Godrick the Grafted", true, 105, 1, 6080, "https://eldenring.wiki.fextralife.com/file/Elden-Ring/godrick_the_grafted_bosses_elden_ring_wiki_600px1-min.jpg", "Stormveil Castle", 20000 },
                    { "dcec86b2-068d-4978-b1fb-5537c4239e30", "Gehrman, The First Hunter", false, 150, 2, 14293, "https://bloodborne.wiki.fextralife.com/file/Bloodborne/gehrman_boss.jpg", "Hunter's Dream", 128000 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "04d88467-5cd2-4e99-bc39-7db9a8e8c22e");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "0a62d641-a5c5-4109-82da-8b748b5e329a");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "28d185da-367b-4441-ac88-f3c28f581fd7");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "32b177e1-1932-431d-bd78-1aa6944c58af");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "339d555b-2ca1-4d59-a8a7-e7b40589d0c0");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "39fe4b5e-29ef-4855-ae9f-c5a3f84207bf");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "3e4eb83b-8ae7-470a-afc4-759e452f1c0a");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "498e0829-386a-4c75-ae5c-b7e288e03ed1");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "601016d4-3bad-4bd4-9e60-31dc09f5e521");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "82c65bc2-ae08-4158-b158-5092e7f2e21a");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "8f1ce319-dd0f-468f-9461-ad9dbd9de136");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "8f8e444d-6a78-4b9c-bf26-d224491ad799");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "90ee3f72-e5e8-4c3b-8010-ea2c69e004fa");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "cdd68fd3-fa61-4fb4-8b93-e8596788509d");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "dcec86b2-068d-4978-b1fb-5537c4239e30");

            migrationBuilder.InsertData(
                table: "Bosses",
                columns: new[] { "Id", "BossName", "Defeated", "Defense", "Game_Id", "Hp", "Image", "Location", "Souls" },
                values: new object[,]
                {
                    { "01cc89b8-15dc-4086-bb22-bfa56c92a20a", "Margit the Fell Omen", true, 103, 1, 4074, "https://eldenring.wiki.fextralife.com/file/Elden-Ring/margit-1-boss-elden-ring-wiki.jpg", "Stormveil Castle", 12000 },
                    { "0ac3e438-c928-437f-8142-c3a0ac0e7b70", "Gehrman, The First Hunter", false, 150, 2, 14293, "https://bloodborne.wiki.fextralife.com/file/Bloodborne/gehrman_boss.jpg", "Hunter's Dream", 128000 },
                    { "0b3f3972-c11e-47ca-ad16-bfee4cb93955", "Isshin, the Sword Saint", false, 700, 6, 10000, "https://sekiroshadowsdietwice.wiki.fextralife.com/file/Sekiro-Shadows-Die-Twice/isshin-sword-saint-boss-sekiro-wiki-guide-300px.png", "Ashina Castle", 2000 },
                    { "1103d44d-7057-48be-8690-49805b6015d9", "Soul of Cinder", false, 150, 5, 10766, "https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/tumblr_o25lubbSXv1qzwtdlo1_1280.jpg", "Kiln of the First Flame", 100000 },
                    { "25a97615-e014-419e-a681-331790ce1876", "Nashandra", false, 135, 4, 8770, "https://darksouls2.wiki.fextralife.com/file/Dark-Souls-2/nashandra.png", "Throne of Want", 90000 },
                    { "294db89d-18f8-4f7c-83fb-0c5004d18d21", "Father Gascoigne", false, 95, 2, 2031, "https://bloodborne.wiki.fextralife.com/file/Bloodborne/father_gascoigne_boss.jpg", "Central Yharnam", 1800 },
                    { "29936042-ca86-4886-ab9f-dd616a5020f9", "Godrick the Grafted", true, 105, 1, 6080, "https://eldenring.wiki.fextralife.com/file/Elden-Ring/godrick_the_grafted_bosses_elden_ring_wiki_600px1-min.jpg", "Stormveil Castle", 20000 },
                    { "2d1c5d0a-52da-49ca-a9f3-27397719edc2", "The Pursuer", false, 123, 4, 3500, "https://darksouls2.wiki.fextralife.com/file/Dark-Souls-2/pursuer.png", "Forest of Fallen Giants", 17000 },
                    { "5d4a0303-db2e-46b8-a7d4-24e1e53e28f7", "Genichiro Ashina", false, 600, 6, 10000, "https://sekiroshadowsdietwice.wiki.fextralife.com/file/Sekiro-Shadows-Die-Twice/genichiro-ashina-boss-sekiro-wiki-guide-300px.png", "Ashina Castle", 20000 },
                    { "63b0390d-dec2-4246-a85a-ad22e9395a93", "Leonine Misbegotten", true, 104, 1, 2198, "https://eldenring.wiki.fextralife.com/file/Elden-Ring/leonine_misbegotten_bosses_elden_ring_wiki_600px1.jpg", "Castle Morne", 3800 },
                    { "aa0abbc1-5208-443a-b2b7-70627ac0e617", "Red Wolf of Radagon", false, 107, 1, 2204, "https://eldenring.wiki.fextralife.com/file/Elden-Ring/red-wolf-of-radagon-2-elden-ring-wiki-guide.jpg", "Raya Lucaria Academy", 14000 },
                    { "dbb43a6d-6fd4-4405-b4d8-fc358faf0806", "Pontiff Sulyvahn", false, 107, 5, 5106, "https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/pontiff_sulyvahn_trophy.PNG", "Irithyll of the Boreal Valley", 28000 },
                    { "de68ca0f-ed5b-47e9-b2aa-67668b2b3a10", "Rennala, Queen of the Full Moon", false, 109, 1, 40000, "https://eldenring.wiki.fextralife.com/file/Elden-Ring/rennala_queen_of_the_full_moon_bosses_elden_ring_wiki_600px1-min.jpg", "Raya Lucaria Academy", 700 },
                    { "ec700e4c-7add-4518-b4eb-4e5a076ba595", "Gwyn, Lord of Cinder", false, 120, 3, 4250, "https://darksouls.wiki.fextralife.com/file/Dark-Souls/Boss_0024_Gwyn%20Lord%20of%20Cinder.jpg", "Kiln of the First Flame", 70000 },
                    { "f465471a-c192-4066-8e61-6d06048c4f87", "Ornstein", false, 100, 3, 1642, "https://darksouls.wiki.fextralife.com/file/Dark-Souls/tumblr_lxlmomDlzY1qgjlhf.jpg", "Anor Londo", 50000 }
                });
        }
    }
}
