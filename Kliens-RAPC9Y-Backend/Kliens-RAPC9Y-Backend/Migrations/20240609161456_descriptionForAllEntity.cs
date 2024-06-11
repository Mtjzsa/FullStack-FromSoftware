using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kliens_RAPC9Y_Backend.Migrations
{
    public partial class descriptionForAllEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "GameDescription",
                table: "Games",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Bosses",
                columns: new[] { "Id", "BossName", "Defense", "Description", "Game_Id", "Hp", "Image", "Location", "Souls" },
                values: new object[,]
                {
                    { "01dc0882-942d-42cd-aad4-e95aec1855b0", "Gwyn, Lord of Cinder", 120, "Gwyn, Lord of Cinder was a mighty warrior and the greatest of lords. He was known as the Lord of Sunlight and headed the efforts to end the Age of Ancients, together with Gravelord Nito, the Witch of Izalith, and the dragon-traitor, Seath the Scaleless. Commanding his knights, he led the Lords to victory and oversaw the Age of Fire. Despite being partially bequeathed to the Four Kings and Seath the Scaleless, his soul remains a powerful thing indeed.\r\n\r\nAround a thousand years prior to the start of the Dark Souls game events, Gwyn sacrificed himself to link the First Flame. His reasons for doing so are disputed, but what is certain is that his principal motivation was to postpone the end of the Age of Fire. He was succeeded by his children: his firstborn, the banished God of War who lost his status as a deity; his daughter Gwynevere, the Queen of Sunlight; and his lastborn Gwyndolin, his \"repulsive [and] frail\" son who Gwyn raised as a daughter due to Gwyndolin's affinity for the Moon.\r\n\r\nIt will come as no surprise to anyone who has spoken to Kingseeker Frampt, Darkstalker Kaathe, or the illusion of Gwynevere, that Lord Gwyn is the final boss of the game, and that it is the Chosen Undead's goal to either succeed him and end further Undead sacrifices, or start the Age of Dark: the apparent age of Humanity. Lord Gwyn can be fought after acquiring all Lord Souls and Lord Soul Shards and returning them to the Lordvessel at Firelink Altar, which will grant access to the Kiln of the First Flame. After fighting past five of his Black Knight, a Hollowed and haggard Gwyn awaits at the site of the First Flame, presenting himself as the final challenge.", 3, 4250, "https://darksouls.wiki.fextralife.com/file/Dark-Souls/Boss_0024_Gwyn%20Lord%20of%20Cinder.jpg", "Kiln of the First Flame", 70000 },
                    { "1dc364ac-93ed-427a-a4e4-980f266fd700", "Margit the Fell Omen", 103, "Margit, the Fell Omen is a Great Enemy Boss in Elden Ring. This is an optional boss as players don't need to defeat him to advance in Elden Ring, though they do need to defeat Margit to advance to Stormveil Castle.\r\n\r\nMargit, the Fell Omen is found in Stormhill when players attempt to approach Stormveil Castle. A non-boss variant can be found later again when approaching a stationary enemy slightly southwest of the Outer Wall Battleground Site of Grace in the Capital Outskirts. Margit stands in the Tarnished's way to prevent them from approaching the Elden Ring, though his motivations are only explained in a later encounter.", 1, 4074, "https://eldenring.wiki.fextralife.com/file/Elden-Ring/margit-1-boss-elden-ring-wiki.jpg", "Stormveil Castle", 12000 },
                    { "426a47fd-a2a5-44b4-877a-e066c08d7590", "Genichiro Ashina", 600, "\r\nGenichiro Ashina\r\ngenichiro ashina sekiro shadows die twice wiki guide\r\nLocation	Ashina Reservoir\r\nAshina Castle\r\nStatus Abnormalities	Shock\r\nUseful Tools	Shinobi Firecracker\r\nLoaded Axe\r\nReward	Memory: Genichiro\r\nBloodsmoke Ninjutsu\r\n\r\nXP	NG: 2000\r\nNG+: 18000\r\nNG++: 27000\r\nGenichiro Ashina (葦名弦一郎, Ashina Genichirou) is a Boss in Sekiro: Shadows Die Twice. This Complete Genichiro Ashina Boss Guide gives you strategies on how to beat Genichiro easily, as well as tips, tricks and lore notes. Bosses like Genichiro are special, dangerous Enemies that feature a special display on-screen when defeated, such as \"Immortality Severed\" or \"Shinobi Execution\". You will need to perform multiple Deathblows on them in order to defeat them, and filling their Posture Gauge is the only way to accomplish this. However, decreasing their health will make it so their Posture Gauge depletes more slowly, assisting you in accomplishing this feat. ", 6, 10000, "https://sekiroshadowsdietwice.wiki.fextralife.com/file/Sekiro-Shadows-Die-Twice/genichiro-ashina-boss-sekiro-wiki-guide-300px.png", "Ashina Castle", 20000 },
                    { "48347cc4-3aff-4fe3-a878-276c8d4bb193", "Leonine Misbegotten", 104, "Leonine Misbegotten is a Great Enemy Boss in Elden Ring. This Elden Ring Leonine Misbegotten Guide features boss locations, tips, strategies and videos on how to defeat the Leonine Misbegotten, as well as boss stats and lore.\r\n\r\nThis misbegotten is a feral humanoid with bestial features and a thick, crimson mane. It wields a large greatsword and is found at the end of Castle Morne. This individual has stolen the treasured sword of Castle Morne, the one Edgar promised to protect. He is summonable for this fight if his and Irina's questline have been progressed to a certain point.\r\n\r\nThis is an optional boss as players are not required to defeat it to advance. The Leonine Misbegotten is extremely aggressive and it may be difficult to find openings to attack it. You will find yourself rolling most of the time in order to create distance as a ranged character, or as an alternative to Guarding as blocking it's attacks will deplete your Stamina quickly. It drops the Grafted Blade Greatsword when defeated.\r\n\r\nBosses are unique and challenging Enemies that can be encountered all over the Lands Between. Great Enemy bosses can drop unique Spirit Ashes, Weapons, Spells, and other various Items.\r\n\r\nLesser Misbegotten Warrior is the normal enemy form of this boss. Other variants of this boss appear in the Crucible Knight and Misbegotten Warrior, Perfumer Tricia and Misbegotten Warrior, and Misbegotten Crusader boss fights.", 1, 2198, "https://eldenring.wiki.fextralife.com/file/Elden-Ring/leonine_misbegotten_bosses_elden_ring_wiki_600px1.jpg", "Castle Morne", 3800 },
                    { "4dd89182-a043-4414-a6f9-79466cbb3010", "Red Wolf of Radagon", 107, "Red Wolf of Radagon is a Great Enemy Boss in Elden Ring. This giant red wolf wields sorceries and guards the found in the Grand Library of Raya Lucaria Academy. This is an optional boss as players don't need to defeat it to advance in Elden Ring, though they do need to defeat it to advance further in Raya Lucaria Academy and to achieve a certain ending.\r\n\r\nLesser Red Wolf of Radagon is the normal enemy form of this boss. Red Wolf of the Champion is another variant of this boss.", 1, 2204, "https://eldenring.wiki.fextralife.com/file/Elden-Ring/red-wolf-of-radagon-2-elden-ring-wiki-guide.jpg", "Raya Lucaria Academy", 14000 },
                    { "54c0d216-5760-4247-9f11-18f048055b87", "The Pursuer", 123, "The Pursuer is a boss in Dark Souls 2. A giant, aggressive knight that relentlessly \"pursues\" the player. Heavily armored in black, it wields the Pursuer's Ultra Greatsword with a corresponding heavy hitter moveset. He can move very quickly for such a large enemy, and can, in particular, close rapidly on the player from a distance.\r\n\r\nCan be encountered in multiple locations as a miniboss if playing SotFS. After the main boss fight in Forest of Fallen Giants, these secondary encounters are not explicit boss fights and do not grant as many souls as the first encounter. In addition, it will already be in it's powered-up curse mode, allowing it to use its powerful Dark Magic attack. These versions generally drop 1 Twinkling Titanite, and will vanish into the ground if you leave the area they spawned in. In NG+, the Pursuer will appear more regularly.", 4, 3500, "https://darksouls2.wiki.fextralife.com/file/Dark-Souls-2/pursuer.png", "Forest of Fallen Giants", 17000 },
                    { "67830080-e800-4bf7-9297-43f6f580b41f", "Isshin, the Sword Saint", 700, "Isshin, The Sword Saint (剣聖、葦名一心; Kensei Ashina Isshin; Sword Saint, Isshin Ashina) is the final Boss in Sekiro: Shadows Die Twice. This Complete Isshin, The Sword Saint Boss Guide gives you strategies on how to beat Isshin easily, as well as tips, tricks and lore notes. Bosses like The Sword Saint are special, dangerous Enemies that feature a special display on-screen when defeated, such as \"Immortality Severed\" or \"Shinobi Execution\". You will need to perform multiple Deathblows on them in order to defeat them, and filling their Posture Gauge is the fastest way to accomplish this. However, decreasing their health will make it so their Posture Gauge depletes more quickly, assisting you in accomplishing this feat.", 6, 10000, "https://sekiroshadowsdietwice.wiki.fextralife.com/file/Sekiro-Shadows-Die-Twice/isshin-sword-saint-boss-sekiro-wiki-guide-300px.png", "Ashina Castle", 2000 },
                    { "84b4b118-17ed-46bb-b4c6-d22ec61a7e90", "Gehrman, The First Hunter", 150, "Gehrman, the First Hunter (最初の狩人ゲールマン Saisho no kariudo Gēruman lit. \"Gehrman, the First Hunter\") is a Boss in Bloodborne, and one of the three possible final bosses of the game.", 2, 14293, "https://bloodborne.wiki.fextralife.com/file/Bloodborne/gehrman_boss.jpg", "Hunter's Dream", 128000 },
                    { "9db4bdfb-81cf-42c2-a6e8-f190a2daa169", "Rennala, Queen of the Full Moon", 109, "Rennala, Queen of the Full Moon is a Legend Boss in Elden Ring. Though not a demigod, Rennala is one of the shardbearers who resides in the Academy of Raya Lucaria. Rennala is a powerful sorceress, head of the Carian Royal family, and erstwhile leader of the Academy. Rennala is an optional boss, and doesn't need to be defeated in order to advance in Elden Ring. However, she is a shardbearer, and two of the five available shardbearers must be defeated before entering Leyndell, Royal Capital. In addition, she must be defeated to achieve a certain ending.\r\n\r\nOnce defeated, Rennala becomes a friendly NPC who can be used to reassign your character's stats.", 1, 40000, "https://eldenring.wiki.fextralife.com/file/Elden-Ring/rennala_queen_of_the_full_moon_bosses_elden_ring_wiki_600px1-min.jpg", "Raya Lucaria Academy", 700 },
                    { "d75fcdc2-09b1-4559-b6a9-74145adae7b4", "Father Gascoigne", 95, "Father Gascoigne (ガスコイン神父 Gasukoin shinpu lit. Father Gascoigne) is a Boss in Bloodborne; he can also be summoned beforehand for a certain boss fight.", 2, 2031, "https://bloodborne.wiki.fextralife.com/file/Bloodborne/father_gascoigne_boss.jpg", "Central Yharnam", 1800 },
                    { "d8f80d65-1174-45e2-badb-4907c6058cba", "Pontiff Sulyvahn", 107, "Pontiff Sulyvahn is a Boss in Dark Souls 3. This Dark Souls 3 Pontiff Sulyvahn Guide features locations, strategies and videos on how to defeat Pontiff Sulyvahn easily, as well as tips, weaknesses, trivia and lore notes for the Pontiff Sulyvahn boss.\r\n\r\nPontiff Sulyvahn is a tall humanoid dressed in bejeweled sorcerer's robes. He wields two greatswords in combat - the greatsword in his left hand emanating a purple aura and the greatsword in his right hand enshrouded in flames. After being brought down to a certain health threshold, branch-like wings sprout from his back.\r\n\r\nDuring combat, the boss attacks players in an aggressively using long sword combos, adding to the difficulty of the fight. This boss is not optional and must be killed for access to part of Irithyll. Three NPCs can be summoned to help you in the fight against Pointiff Sulyvahn:\r\n\r\nBlack Hand Gotthard - in front of Sulyvahn's gate, summoning him will grant the \"By My Sword\" gesture.\r\nLondor Pale Shade - can be summoned in front of a statue to the right when facing the boss fog, as long as the player has been following Yuria's and Yoel's questline, and gives the \"Duel Bow Gesture\" when summoned.\r\nAnri of Astora - Their sign will be to the right (facing away from the fog door) in front of a statue. A seriously powerful summon for this fight, Anri is capable of nearly soloing Sulyvahn, as they’re capable of parrying him.\r\nBosses are unique and challenging Enemies that drop Boss Souls capable of being transformed into powerful Weapons, Spells, and Items for the player.", 5, 5106, "https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/pontiff_sulyvahn_trophy.PNG", "Irithyll of the Boreal Valley", 28000 },
                    { "e72d453d-108a-4b2d-ac30-44122f4952ab", "Ornstein", 100, "Ornstein is the captain of the Four Knights of Gwyn Lord of Cinder, serving alongside Artorias the Abysswalker, Lord's Blade Ciaran, and Hawkeye Gough. As his name would suggest, he was an honorary dragon slayer.\r\n\r\nHe wields his Dragonslayer Spear, a sword-spear after the fashion of Gwyn's Firstborn's own weapon. He also commands the power of lightning. It is believed that he was left behind with Smough to guard Anor Londo's cathedral after the gods fled.\r\n\r\nHowever, there is reason to believe that Ornstein's presence in Anor Londo is an illusion, much as Gwynevere and the light of Anor Londo is a mere facade maintained by Gwyndolin. This is evidenced by his presence in Drangleic, at Heide's Tower of Flame, where we can speculate he might have fled with Gwynevere. There is also the matter of his armour being present in Archdragon Peak, suggesting he followed Gwyn's Firstborn after his betrayal, with some suggesting he even shed his armour and body to become a dragon – not least as the Nameless King echoes the Ornstein and Smough boss fight in absorbing the lightning of his stormdrake, The King of Storm.", 3, 1642, "https://darksouls.wiki.fextralife.com/file/Dark-Souls/tumblr_lxlmomDlzY1qgjlhf.jpg", "Anor Londo", 50000 },
                    { "ec80a176-2468-4281-b69d-c7a2a183e8c8", "Godrick the Grafted", 105, "Godrick the Grafted, also known as Godrick the Golden, is a Demigod Boss in Elden Ring. This Elden Ring Godrick the Grafted Guide features boss locations, tips, strategies and videos on how to defeat Godrick easily, as well as boss stats and lore for Godrick. Bosses are unique and challenging Enemies that can be encountered all over the Lands Between. Shardbearers drop their own unique Great Rune and Remembrance capable of being transformed into powerful Weapons, Spells, Ashes of War, and Talismans for the player.\r\n\r\nGodrick the Grafted is the ruler of Stormveil Castle, and is one of the first demigods and shardbearers that players can fight. He is a descendant of Godfrey and thus born of the golden lineage, but Gideon and Kenneth Haight believe him to be weak and unworthy to rule. Much of Godrick's power comes from the arms and legs of soldiers he's grafted onto himself, and especially the dragon head grafted onto his left arm during the second phase of his fight. His knights and soldiers wear armor that bears emblems of the golden lineage: a two-headed war-axe and the beast regent, Serosh.\r\n\r\nGodrick is an optional boss, and doesn't need to be defeated in order to advance in Elden Ring. You can advance to Liurnia of the Lakes without defeating him by following the path north from Stormhill Shack, then dropping down to the west from the broken bridge and walking along the outside of the castle. However, Godrick is a shardbearer, and two of the five available shardbearers must be defeated before entering Leyndell, Royal Capital.", 1, 6080, "https://eldenring.wiki.fextralife.com/file/Elden-Ring/godrick_the_grafted_bosses_elden_ring_wiki_600px1-min.jpg", "Stormveil Castle", 20000 },
                    { "f38e92cc-002c-49f1-bd4c-7a7964ca4c4e", "Nashandra", 135, "Nashandra is a Boss and NPC in Dark Souls 2 (DKS2). Nashandra, equipped with a scythe and proficient in the arts of dark magic, poses a formidable challenge to the player. Her attacks carry significant lethality, capable of delivering fatal blows with a single strike. Additionally, she summons wisps akin to the Cursed Vessel encountered in the Shaded Woods, albeit swifter and possessing the ability to inflict direct damage. These wisps can be eliminated using any form of attack. Bosses are unique and challenging Enemies that drop Boss Souls capable of being transformed into powerful Weapons, Spells, and Items for the player.", 4, 8770, "https://darksouls2.wiki.fextralife.com/file/Dark-Souls-2/nashandra.png", "Throne of Want", 90000 },
                    { "fac46ad2-0298-47e3-a1aa-c17ca7fe5292", "Soul of Cinder", 150, "Soul of Cinder is a Boss and is the Final Boss of Dark Souls 3. This Dark Souls 3 Soul of Cinder Guide features locations, strategies and videos on how to defeat the Soul of Cinder easily, as well as tips, weaknesses, trivia and lore notes for the Soul of Cinder boss.\r\n\r\nThe Soul of Cinder is seen as the amalgamation of all the Lords of Cinder, with a variety of Dark Dialectics spells and movesets used during its first phase and the use of Gwyn's moveset for the second phase. It appears to the player as a heavily armored knight and wields the Firelink Greatsword in battle, a greatsword that can change into one of three other forms during the first phase of the fight. After depleting it's health once, the second phase starts, where the boss regains all his health and sticks to one moveset.\r\n\r\nThis boss fight can be difficult due to the unpredictability of its moves in the first phase. This guide aims to not only inform players of its moveset in all weapon forms, but also how to best deal with them. Two NPCs can be summoned to aid you in the fight against the Soul of Cinder:\r\n\r\nYuria of Londor - Must have done Anri's event in Darkmoon tomb and Yuria must not be hostile. Summon sign can be found just before the boss fog.\r\nLondor Pale Shade - Summon can be found at mid way up the long winding stairs to the boss arena, turn to your right look for the white sign. Only available if allied with Yuria.\r\nThis boss is not optional and is required to finish the game. For endings after defeating it, see the Game Progress Route and/or Kiln of the First Flame.\r\n\r\nBosses are unique and challenging Enemies that drop Boss Souls capable of being transformed into powerful Weapons, Spells, and Items for the player.", 5, 10766, "https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/tumblr_o25lubbSXv1qzwtdlo1_1280.jpg", "Kiln of the First Flame", 100000 }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                column: "GameDescription",
                value: "Elden Ring is an upcoming action role-playing game developed by FromSoftware in collaboration with acclaimed author George R.R. Martin. Set in a vast and fantastical world known as the Lands Between, Elden Ring promises to deliver the signature challenging gameplay and rich storytelling that FromSoftware is known for. Players will embark on an epic journey as they explore diverse landscapes, encounter formidable foes, and uncover the mysteries of the shattered Elden Ring. With its expansive open-world environment, deep lore, and dynamic combat system, Elden Ring is poised to offer an immersive and unforgettable experience for fans of the genre and newcomers alike.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                column: "GameDescription",
                value: "Bloodborne is an atmospheric action role-playing game set in a gothic, horror-infused world. Players take on the role of a Hunter in the city of Yharnam, plagued by a mysterious blood-borne illness. As they explore the twisted streets and eerie landscapes, they encounter grotesque creatures, challenging enemies, and eldritch horrors lurking in the shadows. The game's fast-paced combat requires precise timing and strategic thinking, rewarding players for their skill and adaptability. With its haunting atmosphere, intricate level design, and deep lore, Bloodborne offers a gripping and immersive experience that will test players' courage and determination as they uncover the dark secrets of Yharnam.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                column: "GameDescription",
                value: "Dark Souls is a challenging action role-playing game known for its unforgiving difficulty and intricate world design. Players navigate a dark and atmospheric fantasy realm filled with perilous enemies, intricate level layouts, and mysterious lore. As they journey through the game, they encounter epic battles, daunting bosses, and deep exploration, all set against a backdrop of despair and decay. Dark Souls emphasizes player skill and strategic thinking, rewarding perseverance and careful observation as players uncover the secrets of its haunting world.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                column: "GameDescription",
                value: "Dark Souls 2 is the sequel to the acclaimed action role-playing game, continuing the series' tradition of challenging gameplay and atmospheric world-building. Set in a new realm known as Drangleic, players embark on a journey filled with treacherous enemies, intricate level design, and deep lore. Like its predecessor, Dark Souls 2 tests players' skills through demanding combat encounters and formidable bosses. The game expands upon the series' signature mechanics while introducing new gameplay elements and a diverse range of environments to explore. Dark Souls 2 offers a compelling and immersive experience for players seeking a test of their courage and perseverance.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                column: "GameDescription",
                value: "Dark Souls 3 is the culmination of the acclaimed action role-playing series, offering a challenging and immersive experience for players. Set in a dying world on the brink of apocalypse, players journey through a dark and atmospheric realm filled with menacing enemies, intricate level design, and rich lore. The game features intense combat encounters, epic boss battles, and deep exploration as players uncover the secrets of the world and confront their own mortality. With refined gameplay mechanics, stunning visuals, and a haunting soundtrack, Dark Souls 3 delivers a gripping and unforgettable journey for those brave enough to face its trials.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                column: "GameDescription",
                value: "In Sekiro: Shadows Die Twice you are the \"one-armed wolf\", a disgraced and disfigured warrior rescued from the brink of death. Bound to protect a young lord who is the descendant of an ancient bloodline, you become the target of many vicious enemies, including the dangerous Ashina clan. When the young lord is captured, nothing will stop you on a perilous quest to regain your honor, not even death itself. ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "01dc0882-942d-42cd-aad4-e95aec1855b0");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "1dc364ac-93ed-427a-a4e4-980f266fd700");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "426a47fd-a2a5-44b4-877a-e066c08d7590");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "48347cc4-3aff-4fe3-a878-276c8d4bb193");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "4dd89182-a043-4414-a6f9-79466cbb3010");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "54c0d216-5760-4247-9f11-18f048055b87");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "67830080-e800-4bf7-9297-43f6f580b41f");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "84b4b118-17ed-46bb-b4c6-d22ec61a7e90");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "9db4bdfb-81cf-42c2-a6e8-f190a2daa169");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "d75fcdc2-09b1-4559-b6a9-74145adae7b4");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "d8f80d65-1174-45e2-badb-4907c6058cba");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "e72d453d-108a-4b2d-ac30-44122f4952ab");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "ec80a176-2468-4281-b69d-c7a2a183e8c8");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "f38e92cc-002c-49f1-bd4c-7a7964ca4c4e");

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: "fac46ad2-0298-47e3-a1aa-c17ca7fe5292");

            migrationBuilder.DropColumn(
                name: "GameDescription",
                table: "Games");

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
    }
}
