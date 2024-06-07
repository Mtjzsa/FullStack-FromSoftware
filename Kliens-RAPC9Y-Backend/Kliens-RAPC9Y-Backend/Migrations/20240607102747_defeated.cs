using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kliens_RAPC9Y_Backend.Migrations
{
    public partial class defeated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "03164434-28db-48da-a8fd-7b565b76931b");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "0b13e338-2147-4194-954b-9c341d6741b8");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "0e67e935-667c-45ff-97ab-86abd1e67773");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "18375eb6-f278-41b7-b5e7-a14313849f3f");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "289e8dee-e3c0-435f-bbd2-81d00141e201");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "2f20d779-407c-4df9-9804-bf10692ebb1f");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "32fa989b-53eb-44b9-9b66-74fa8ae690a8");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "52c03d83-8f83-41d4-8f4e-3902035b2e61");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "5bc792ff-bc91-4da2-9c83-a84da0e1a9aa");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "5dc555ac-87d5-41ab-8ea3-5dae413c619a");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "6a5feb1e-0893-456f-9d01-584bbf74286d");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "6ec4f2f7-40f4-4f4e-82a8-d927937b3abe");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "a6187575-bca7-403d-98fc-637ee8f6a32f");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "e0122de2-0946-4977-bc14-1eb32e2f12f9");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "e7a74579-e7aa-4e0c-a6a4-a848d604312e");

            migrationBuilder.AddColumn<string>(
                name: "DefeatedBosses",
                table: "AspNetUsers",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "DefeatedBosses",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "Bosses",
                columns: new[] { "Id", "BossName", "Defense", "Game_Id", "Hp", "Image", "Location", "Souls" },
                values: new object[,]
                {
                    { "03164434-28db-48da-a8fd-7b565b76931b", "Soul of Cinder", 150, 5, 10766, "https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/tumblr_o25lubbSXv1qzwtdlo1_1280.jpg", "Kiln of the First Flame", 100000 },
                    { "0b13e338-2147-4194-954b-9c341d6741b8", "Father Gascoigne", 95, 2, 2031, "https://bloodborne.wiki.fextralife.com/file/Bloodborne/father_gascoigne_boss.jpg", "Central Yharnam", 1800 },
                    { "0e67e935-667c-45ff-97ab-86abd1e67773", "Gehrman, The First Hunter", 150, 2, 14293, "https://bloodborne.wiki.fextralife.com/file/Bloodborne/gehrman_boss.jpg", "Hunter's Dream", 128000 },
                    { "18375eb6-f278-41b7-b5e7-a14313849f3f", "Ornstein", 100, 3, 1642, "https://darksouls.wiki.fextralife.com/file/Dark-Souls/tumblr_lxlmomDlzY1qgjlhf.jpg", "Anor Londo", 50000 },
                    { "289e8dee-e3c0-435f-bbd2-81d00141e201", "Gwyn, Lord of Cinder", 120, 3, 4250, "https://darksouls.wiki.fextralife.com/file/Dark-Souls/Boss_0024_Gwyn%20Lord%20of%20Cinder.jpg", "Kiln of the First Flame", 70000 },
                    { "2f20d779-407c-4df9-9804-bf10692ebb1f", "Red Wolf of Radagon", 107, 1, 2204, "https://eldenring.wiki.fextralife.com/file/Elden-Ring/red-wolf-of-radagon-2-elden-ring-wiki-guide.jpg", "Raya Lucaria Academy", 14000 },
                    { "32fa989b-53eb-44b9-9b66-74fa8ae690a8", "Godrick the Grafted", 105, 1, 6080, "https://eldenring.wiki.fextralife.com/file/Elden-Ring/godrick_the_grafted_bosses_elden_ring_wiki_600px1-min.jpg", "Stormveil Castle", 20000 },
                    { "52c03d83-8f83-41d4-8f4e-3902035b2e61", "Nashandra", 135, 4, 8770, "https://darksouls2.wiki.fextralife.com/file/Dark-Souls-2/nashandra.png", "Throne of Want", 90000 },
                    { "5bc792ff-bc91-4da2-9c83-a84da0e1a9aa", "Leonine Misbegotten", 104, 1, 2198, "https://eldenring.wiki.fextralife.com/file/Elden-Ring/leonine_misbegotten_bosses_elden_ring_wiki_600px1.jpg", "Castle Morne", 3800 },
                    { "5dc555ac-87d5-41ab-8ea3-5dae413c619a", "Margit the Fell Omen", 103, 1, 4074, "https://eldenring.wiki.fextralife.com/file/Elden-Ring/margit-1-boss-elden-ring-wiki.jpg", "Stormveil Castle", 12000 },
                    { "6a5feb1e-0893-456f-9d01-584bbf74286d", "Isshin, the Sword Saint", 700, 6, 10000, "https://sekiroshadowsdietwice.wiki.fextralife.com/file/Sekiro-Shadows-Die-Twice/isshin-sword-saint-boss-sekiro-wiki-guide-300px.png", "Ashina Castle", 2000 },
                    { "6ec4f2f7-40f4-4f4e-82a8-d927937b3abe", "Rennala, Queen of the Full Moon", 109, 1, 40000, "https://eldenring.wiki.fextralife.com/file/Elden-Ring/rennala_queen_of_the_full_moon_bosses_elden_ring_wiki_600px1-min.jpg", "Raya Lucaria Academy", 700 },
                    { "a6187575-bca7-403d-98fc-637ee8f6a32f", "Genichiro Ashina", 600, 6, 10000, "https://sekiroshadowsdietwice.wiki.fextralife.com/file/Sekiro-Shadows-Die-Twice/genichiro-ashina-boss-sekiro-wiki-guide-300px.png", "Ashina Castle", 20000 },
                    { "e0122de2-0946-4977-bc14-1eb32e2f12f9", "The Pursuer", 123, 4, 3500, "https://darksouls2.wiki.fextralife.com/file/Dark-Souls-2/pursuer.png", "Forest of Fallen Giants", 17000 },
                    { "e7a74579-e7aa-4e0c-a6a4-a848d604312e", "Pontiff Sulyvahn", 107, 5, 5106, "https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/pontiff_sulyvahn_trophy.PNG", "Irithyll of the Boreal Valley", 28000 }
                });
        }
    }
}
