﻿// <auto-generated />
using System;
using Kliens_RAPC9Y_Backend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Kliens_RAPC9Y_Backend.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20240609155321_bossDescriptionAdded")]
    partial class bossDescriptionAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Kliens_RAPC9Y_Backend.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DefeatedBosses")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Kliens_RAPC9Y_Backend.Models.Boss", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BossName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Defense")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Game_Id")
                        .HasColumnType("int");

                    b.Property<int>("Hp")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Souls")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Game_Id");

                    b.ToTable("Bosses");

                    b.HasData(
                        new
                        {
                            Id = "705f060b-73d1-4481-9802-200c137f1015",
                            BossName = "Margit the Fell Omen",
                            Defense = 103,
                            Description = "Margit, the Fell Omen is a Great Enemy Boss in Elden Ring. This is an optional boss as players don't need to defeat him to advance in Elden Ring, though they do need to defeat Margit to advance to Stormveil Castle.\r\n\r\nMargit, the Fell Omen is found in Stormhill when players attempt to approach Stormveil Castle. A non-boss variant can be found later again when approaching a stationary enemy slightly southwest of the Outer Wall Battleground Site of Grace in the Capital Outskirts. Margit stands in the Tarnished's way to prevent them from approaching the Elden Ring, though his motivations are only explained in a later encounter.",
                            Game_Id = 1,
                            Hp = 4074,
                            Image = "https://eldenring.wiki.fextralife.com/file/Elden-Ring/margit-1-boss-elden-ring-wiki.jpg",
                            Location = "Stormveil Castle",
                            Souls = 12000
                        },
                        new
                        {
                            Id = "e3ab6da6-81ec-4bfc-adf6-b120b4f7ed78",
                            BossName = "Godrick the Grafted",
                            Defense = 105,
                            Description = "Godrick the Grafted, also known as Godrick the Golden, is a Demigod Boss in Elden Ring. This Elden Ring Godrick the Grafted Guide features boss locations, tips, strategies and videos on how to defeat Godrick easily, as well as boss stats and lore for Godrick. Bosses are unique and challenging Enemies that can be encountered all over the Lands Between. Shardbearers drop their own unique Great Rune and Remembrance capable of being transformed into powerful Weapons, Spells, Ashes of War, and Talismans for the player.\r\n\r\nGodrick the Grafted is the ruler of Stormveil Castle, and is one of the first demigods and shardbearers that players can fight. He is a descendant of Godfrey and thus born of the golden lineage, but Gideon and Kenneth Haight believe him to be weak and unworthy to rule. Much of Godrick's power comes from the arms and legs of soldiers he's grafted onto himself, and especially the dragon head grafted onto his left arm during the second phase of his fight. His knights and soldiers wear armor that bears emblems of the golden lineage: a two-headed war-axe and the beast regent, Serosh.\r\n\r\nGodrick is an optional boss, and doesn't need to be defeated in order to advance in Elden Ring. You can advance to Liurnia of the Lakes without defeating him by following the path north from Stormhill Shack, then dropping down to the west from the broken bridge and walking along the outside of the castle. However, Godrick is a shardbearer, and two of the five available shardbearers must be defeated before entering Leyndell, Royal Capital.",
                            Game_Id = 1,
                            Hp = 6080,
                            Image = "https://eldenring.wiki.fextralife.com/file/Elden-Ring/godrick_the_grafted_bosses_elden_ring_wiki_600px1-min.jpg",
                            Location = "Stormveil Castle",
                            Souls = 20000
                        },
                        new
                        {
                            Id = "854363df-3fd1-4cb5-ad53-c23f8ff142d9",
                            BossName = "Red Wolf of Radagon",
                            Defense = 107,
                            Description = "Red Wolf of Radagon is a Great Enemy Boss in Elden Ring. This giant red wolf wields sorceries and guards the found in the Grand Library of Raya Lucaria Academy. This is an optional boss as players don't need to defeat it to advance in Elden Ring, though they do need to defeat it to advance further in Raya Lucaria Academy and to achieve a certain ending.\r\n\r\nLesser Red Wolf of Radagon is the normal enemy form of this boss. Red Wolf of the Champion is another variant of this boss.",
                            Game_Id = 1,
                            Hp = 2204,
                            Image = "https://eldenring.wiki.fextralife.com/file/Elden-Ring/red-wolf-of-radagon-2-elden-ring-wiki-guide.jpg",
                            Location = "Raya Lucaria Academy",
                            Souls = 14000
                        },
                        new
                        {
                            Id = "49cbb513-a95e-488a-a99b-e1dca5f118a3",
                            BossName = "Rennala, Queen of the Full Moon",
                            Defense = 109,
                            Description = "",
                            Game_Id = 1,
                            Hp = 40000,
                            Image = "https://eldenring.wiki.fextralife.com/file/Elden-Ring/rennala_queen_of_the_full_moon_bosses_elden_ring_wiki_600px1-min.jpg",
                            Location = "Raya Lucaria Academy",
                            Souls = 700
                        },
                        new
                        {
                            Id = "354855a3-8f70-4c78-8f1b-44528b361c5e",
                            BossName = "Leonine Misbegotten",
                            Defense = 104,
                            Description = "",
                            Game_Id = 1,
                            Hp = 2198,
                            Image = "https://eldenring.wiki.fextralife.com/file/Elden-Ring/leonine_misbegotten_bosses_elden_ring_wiki_600px1.jpg",
                            Location = "Castle Morne",
                            Souls = 3800
                        },
                        new
                        {
                            Id = "9a09899c-fc65-41d9-96ff-ff1047a796bb",
                            BossName = "Father Gascoigne",
                            Defense = 95,
                            Description = "",
                            Game_Id = 2,
                            Hp = 2031,
                            Image = "https://bloodborne.wiki.fextralife.com/file/Bloodborne/father_gascoigne_boss.jpg",
                            Location = "Central Yharnam",
                            Souls = 1800
                        },
                        new
                        {
                            Id = "cb35a414-6096-4017-a88f-b5c07f92bd69",
                            BossName = "Gehrman, The First Hunter",
                            Defense = 150,
                            Description = "",
                            Game_Id = 2,
                            Hp = 14293,
                            Image = "https://bloodborne.wiki.fextralife.com/file/Bloodborne/gehrman_boss.jpg",
                            Location = "Hunter's Dream",
                            Souls = 128000
                        },
                        new
                        {
                            Id = "5d4db694-6804-459d-9e2e-a4f72f7cfef2",
                            BossName = "Gwyn, Lord of Cinder",
                            Defense = 120,
                            Description = "",
                            Game_Id = 3,
                            Hp = 4250,
                            Image = "https://darksouls.wiki.fextralife.com/file/Dark-Souls/Boss_0024_Gwyn%20Lord%20of%20Cinder.jpg",
                            Location = "Kiln of the First Flame",
                            Souls = 70000
                        },
                        new
                        {
                            Id = "8cb272c6-afdb-48ba-9a56-51739b3a57fd",
                            BossName = "Ornstein",
                            Defense = 100,
                            Description = "",
                            Game_Id = 3,
                            Hp = 1642,
                            Image = "https://darksouls.wiki.fextralife.com/file/Dark-Souls/tumblr_lxlmomDlzY1qgjlhf.jpg",
                            Location = "Anor Londo",
                            Souls = 50000
                        },
                        new
                        {
                            Id = "2693f4b1-80c6-4b66-b2ba-906133eee594",
                            BossName = "Nashandra",
                            Defense = 135,
                            Description = "",
                            Game_Id = 4,
                            Hp = 8770,
                            Image = "https://darksouls2.wiki.fextralife.com/file/Dark-Souls-2/nashandra.png",
                            Location = "Throne of Want",
                            Souls = 90000
                        },
                        new
                        {
                            Id = "1ad79df4-3ae7-4bcf-a483-932443e5099a",
                            BossName = "The Pursuer",
                            Defense = 123,
                            Description = "",
                            Game_Id = 4,
                            Hp = 3500,
                            Image = "https://darksouls2.wiki.fextralife.com/file/Dark-Souls-2/pursuer.png",
                            Location = "Forest of Fallen Giants",
                            Souls = 17000
                        },
                        new
                        {
                            Id = "8b52d754-4a44-4b5e-be26-6312d6f3be0d",
                            BossName = "Soul of Cinder",
                            Defense = 150,
                            Description = "",
                            Game_Id = 5,
                            Hp = 10766,
                            Image = "https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/tumblr_o25lubbSXv1qzwtdlo1_1280.jpg",
                            Location = "Kiln of the First Flame",
                            Souls = 100000
                        },
                        new
                        {
                            Id = "28a28fc4-8133-4b05-bb2a-d7eca0a76841",
                            BossName = "Pontiff Sulyvahn",
                            Defense = 107,
                            Description = "",
                            Game_Id = 5,
                            Hp = 5106,
                            Image = "https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/pontiff_sulyvahn_trophy.PNG",
                            Location = "Irithyll of the Boreal Valley",
                            Souls = 28000
                        },
                        new
                        {
                            Id = "3a9dfd7d-dfe2-45c2-b966-84adbf34e057",
                            BossName = "Isshin, the Sword Saint",
                            Defense = 700,
                            Description = "",
                            Game_Id = 6,
                            Hp = 10000,
                            Image = "https://sekiroshadowsdietwice.wiki.fextralife.com/file/Sekiro-Shadows-Die-Twice/isshin-sword-saint-boss-sekiro-wiki-guide-300px.png",
                            Location = "Ashina Castle",
                            Souls = 2000
                        },
                        new
                        {
                            Id = "5aabf439-2265-4d7c-8d3f-91215ec8547b",
                            BossName = "Genichiro Ashina",
                            Defense = 600,
                            Description = "",
                            Game_Id = 6,
                            Hp = 10000,
                            Image = "https://sekiroshadowsdietwice.wiki.fextralife.com/file/Sekiro-Shadows-Die-Twice/genichiro-ashina-boss-sekiro-wiki-guide-300px.png",
                            Location = "Ashina Castle",
                            Souls = 20000
                        });
                });

            modelBuilder.Entity("Kliens_RAPC9Y_Backend.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("GameCover")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GameName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReleaseDate")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GameCover = "https://media.fromsoftware.jp/fromsoftware/ww/static/img/products/title_img/high/img_titlearchive_105.jpg",
                            GameName = "Elden Ring",
                            ReleaseDate = 2022
                        },
                        new
                        {
                            Id = 2,
                            GameCover = "https://media.fromsoftware.jp/fromsoftware/ww/static/img/products/title_img/high/img_titlearchive_94.jpg",
                            GameName = "Bloodborne",
                            ReleaseDate = 2015
                        },
                        new
                        {
                            Id = 3,
                            GameCover = "https://media.fromsoftware.jp/fromsoftware/ww/static/img/products/title_img/high/img_titlearchive_86.jpg",
                            GameName = "Dark Souls",
                            ReleaseDate = 2011
                        },
                        new
                        {
                            Id = 4,
                            GameCover = "https://media.fromsoftware.jp/fromsoftware/ww/static/img/products/title_img/high/img_titlearchive_92.jpg",
                            GameName = "Dark Souls II",
                            ReleaseDate = 2014
                        },
                        new
                        {
                            Id = 5,
                            GameCover = "https://media.fromsoftware.jp/fromsoftware/ww/static/img/products/title_img/high/img_titlearchive_97.jpg",
                            GameName = "Dark Souls III",
                            ReleaseDate = 2016
                        },
                        new
                        {
                            Id = 6,
                            GameCover = "https://media.fromsoftware.jp/fromsoftware/ww/static/img/products/title_img/high/img_titlearchive_102.jpg",
                            GameName = "Sekiro: Shadows Die Twice",
                            ReleaseDate = 2019
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "2",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Kliens_RAPC9Y_Backend.Models.Boss", b =>
                {
                    b.HasOne("Kliens_RAPC9Y_Backend.Models.Game", "Game")
                        .WithMany("Bosses")
                        .HasForeignKey("Game_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Kliens_RAPC9Y_Backend.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Kliens_RAPC9Y_Backend.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Kliens_RAPC9Y_Backend.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Kliens_RAPC9Y_Backend.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Kliens_RAPC9Y_Backend.Models.Game", b =>
                {
                    b.Navigation("Bosses");
                });
#pragma warning restore 612, 618
        }
    }
}
