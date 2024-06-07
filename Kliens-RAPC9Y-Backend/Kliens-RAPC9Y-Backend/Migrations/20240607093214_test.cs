using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kliens_RAPC9Y_Backend.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "0aed0e50-7ab6-467d-83ac-d89a9cc07395", "Rennala, Queen of the Full Moon", false, 109, 1, 40000, "https://eldenring.wiki.fextralife.com/file/Elden-Ring/rennala_queen_of_the_full_moon_bosses_elden_ring_wiki_600px1-min.jpg", "Raya Lucaria Academy", 700 },
                    { "0bd0573f-f431-43ee-95f8-d364758dd8eb", "Nashandra", false, 135, 4, 8770, "https://darksouls2.wiki.fextralife.com/file/Dark-Souls-2/nashandra.png", "Throne of Want", 90000 },
                    { "13164059-3f20-413d-a9f9-4d65394d631a", "Margit the Fell Omen", true, 103, 1, 4074, "https://eldenring.wiki.fextralife.com/file/Elden-Ring/margit-1-boss-elden-ring-wiki.jpg", "Stormveil Castle", 12000 },
                    { "1f2a80ce-d103-4faa-b65b-09f5a0b8629b", "Godrick the Grafted", true, 105, 1, 6080, "https://eldenring.wiki.fextralife.com/file/Elden-Ring/godrick_the_grafted_bosses_elden_ring_wiki_600px1-min.jpg", "Stormveil Castle", 20000 },
                    { "22dbffc0-c436-4d26-90a5-b13c4c0f4967", "Gwyn, Lord of Cinder", false, 120, 3, 4250, "https://darksouls.wiki.fextralife.com/file/Dark-Souls/Boss_0024_Gwyn%20Lord%20of%20Cinder.jpg", "Kiln of the First Flame", 70000 },
                    { "25c2ca8a-7677-4ace-9f2a-7a9c9a278563", "Isshin, the Sword Saint", false, 700, 6, 10000, "https://sekiroshadowsdietwice.wiki.fextralife.com/file/Sekiro-Shadows-Die-Twice/isshin-sword-saint-boss-sekiro-wiki-guide-300px.png", "Ashina Castle", 2000 },
                    { "3e45d52a-1d68-44ae-b4db-d57e97795a29", "Pontiff Sulyvahn", false, 107, 5, 5106, "https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/pontiff_sulyvahn_trophy.PNG", "Irithyll of the Boreal Valley", 28000 },
                    { "42c48104-2494-4071-9ab2-b33038137b2f", "Red Wolf of Radagon", false, 107, 1, 2204, "https://eldenring.wiki.fextralife.com/file/Elden-Ring/red-wolf-of-radagon-2-elden-ring-wiki-guide.jpg", "Raya Lucaria Academy", 14000 },
                    { "452bd7c9-64e8-49eb-9931-6bd56d85e575", "The Pursuer", false, 123, 4, 3500, "https://darksouls2.wiki.fextralife.com/file/Dark-Souls-2/pursuer.png", "Forest of Fallen Giants", 17000 },
                    { "537845a8-56a2-46dd-aafd-6a92572be024", "Gehrman, The First Hunter", false, 150, 2, 14293, "https://bloodborne.wiki.fextralife.com/file/Bloodborne/gehrman_boss.jpg", "Hunter's Dream", 128000 },
                    { "992b3cb5-0bb7-4403-aa14-51cbe0ca69e7", "Father Gascoigne", false, 95, 2, 2031, "https://bloodborne.wiki.fextralife.com/file/Bloodborne/father_gascoigne_boss.jpg", "Central Yharnam", 1800 },
                    { "9db9b94d-c87b-4ab8-80e5-cbcccd29c917", "Genichiro Ashina", false, 600, 6, 10000, "https://sekiroshadowsdietwice.wiki.fextralife.com/file/Sekiro-Shadows-Die-Twice/genichiro-ashina-boss-sekiro-wiki-guide-300px.png", "Ashina Castle", 20000 },
                    { "a0e5c7a0-3686-4a28-8b7d-2843a15b733a", "Ornstein", false, 100, 3, 1642, "https://darksouls.wiki.fextralife.com/file/Dark-Souls/tumblr_lxlmomDlzY1qgjlhf.jpg", "Anor Londo", 50000 },
                    { "a1c86678-53d5-4e04-b69b-92e2ec6d62d9", "Leonine Misbegotten", true, 104, 1, 2198, "https://eldenring.wiki.fextralife.com/file/Elden-Ring/leonine_misbegotten_bosses_elden_ring_wiki_600px1.jpg", "Castle Morne", 3800 },
                    { "dfbd7b32-2d9a-4cf2-86d7-cb591159db85", "Soul of Cinder", false, 150, 5, 10766, "https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/tumblr_o25lubbSXv1qzwtdlo1_1280.jpg", "Kiln of the First Flame", 100000 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "0aed0e50-7ab6-467d-83ac-d89a9cc07395");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "0bd0573f-f431-43ee-95f8-d364758dd8eb");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "13164059-3f20-413d-a9f9-4d65394d631a");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "1f2a80ce-d103-4faa-b65b-09f5a0b8629b");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "22dbffc0-c436-4d26-90a5-b13c4c0f4967");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "25c2ca8a-7677-4ace-9f2a-7a9c9a278563");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "3e45d52a-1d68-44ae-b4db-d57e97795a29");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "42c48104-2494-4071-9ab2-b33038137b2f");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "452bd7c9-64e8-49eb-9931-6bd56d85e575");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "537845a8-56a2-46dd-aafd-6a92572be024");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "992b3cb5-0bb7-4403-aa14-51cbe0ca69e7");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "9db9b94d-c87b-4ab8-80e5-cbcccd29c917");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "a0e5c7a0-3686-4a28-8b7d-2843a15b733a");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "a1c86678-53d5-4e04-b69b-92e2ec6d62d9");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "dfbd7b32-2d9a-4cf2-86d7-cb591159db85");

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
    }
}
