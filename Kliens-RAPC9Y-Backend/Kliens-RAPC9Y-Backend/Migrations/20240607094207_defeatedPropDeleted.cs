using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kliens_RAPC9Y_Backend.Migrations
{
    public partial class defeatedPropDeleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Defeated",
                table: "Bosses");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "Defeated",
                table: "Bosses",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
    }
}
