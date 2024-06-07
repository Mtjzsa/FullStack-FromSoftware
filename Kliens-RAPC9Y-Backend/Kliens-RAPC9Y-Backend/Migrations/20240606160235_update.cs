using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kliens_RAPC9Y_Backend.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "14bd17fd-1dc2-4aa4-997f-a6ab1d6ca8d3");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "16addf84-ccd0-4a19-94e3-982274c4f0e0");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "1969e88d-3547-4b3a-8982-b845791c02f1");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "31176dc7-36df-4d39-bbde-eb48b63d102a");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "345e756a-250d-4d19-9061-6184f0002e40");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "544e69d9-a53f-4cc7-aad3-384fb1cc1808");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "59c0f7c1-b77f-4d66-b0fd-da7a45b8ad04");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "63c10eb7-8fb0-4270-9e97-0f55f2e042bc");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "6adde697-9787-48f9-834c-1277caa29824");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "70bd01e1-29ca-451c-b17b-1b6d7efb6b75");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "8e05559e-ca89-4224-9802-e56cb7f670c9");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "b742202c-79bc-4a89-90a1-52be12db3a9d");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "dec83cbc-5ec9-46e4-ac85-230c3d03fc43");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "ec30e37b-6384-4b33-9ed6-93e217a4fbf3");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "f8591bf3-8dea-4c56-bee0-3475b0f0a208");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
