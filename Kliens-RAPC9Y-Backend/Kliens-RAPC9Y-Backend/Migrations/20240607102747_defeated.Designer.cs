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
    [Migration("20240607102747_defeated")]
    partial class defeated
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
                            Id = "1d98abe8-067d-40d5-9c6b-3975c3395df2",
                            BossName = "Margit the Fell Omen",
                            Defense = 103,
                            Game_Id = 1,
                            Hp = 4074,
                            Image = "https://eldenring.wiki.fextralife.com/file/Elden-Ring/margit-1-boss-elden-ring-wiki.jpg",
                            Location = "Stormveil Castle",
                            Souls = 12000
                        },
                        new
                        {
                            Id = "dbe98d21-8266-4a1d-b8c3-d79a0bdc3f12",
                            BossName = "Godrick the Grafted",
                            Defense = 105,
                            Game_Id = 1,
                            Hp = 6080,
                            Image = "https://eldenring.wiki.fextralife.com/file/Elden-Ring/godrick_the_grafted_bosses_elden_ring_wiki_600px1-min.jpg",
                            Location = "Stormveil Castle",
                            Souls = 20000
                        },
                        new
                        {
                            Id = "d0bf53bf-eea8-4981-96fe-19e0f6993485",
                            BossName = "Red Wolf of Radagon",
                            Defense = 107,
                            Game_Id = 1,
                            Hp = 2204,
                            Image = "https://eldenring.wiki.fextralife.com/file/Elden-Ring/red-wolf-of-radagon-2-elden-ring-wiki-guide.jpg",
                            Location = "Raya Lucaria Academy",
                            Souls = 14000
                        },
                        new
                        {
                            Id = "18ad68da-9304-4feb-ac11-6047d65c4e0d",
                            BossName = "Rennala, Queen of the Full Moon",
                            Defense = 109,
                            Game_Id = 1,
                            Hp = 40000,
                            Image = "https://eldenring.wiki.fextralife.com/file/Elden-Ring/rennala_queen_of_the_full_moon_bosses_elden_ring_wiki_600px1-min.jpg",
                            Location = "Raya Lucaria Academy",
                            Souls = 700
                        },
                        new
                        {
                            Id = "b61c1f05-d89c-43d4-ae69-6e5d0fa00f0c",
                            BossName = "Leonine Misbegotten",
                            Defense = 104,
                            Game_Id = 1,
                            Hp = 2198,
                            Image = "https://eldenring.wiki.fextralife.com/file/Elden-Ring/leonine_misbegotten_bosses_elden_ring_wiki_600px1.jpg",
                            Location = "Castle Morne",
                            Souls = 3800
                        },
                        new
                        {
                            Id = "04f1d6de-e104-4c37-8e41-eecaff30bf42",
                            BossName = "Father Gascoigne",
                            Defense = 95,
                            Game_Id = 2,
                            Hp = 2031,
                            Image = "https://bloodborne.wiki.fextralife.com/file/Bloodborne/father_gascoigne_boss.jpg",
                            Location = "Central Yharnam",
                            Souls = 1800
                        },
                        new
                        {
                            Id = "ef62f043-14c6-4140-bc24-89161461a63c",
                            BossName = "Gehrman, The First Hunter",
                            Defense = 150,
                            Game_Id = 2,
                            Hp = 14293,
                            Image = "https://bloodborne.wiki.fextralife.com/file/Bloodborne/gehrman_boss.jpg",
                            Location = "Hunter's Dream",
                            Souls = 128000
                        },
                        new
                        {
                            Id = "21fa331b-5954-41fb-b562-27730cb1274b",
                            BossName = "Gwyn, Lord of Cinder",
                            Defense = 120,
                            Game_Id = 3,
                            Hp = 4250,
                            Image = "https://darksouls.wiki.fextralife.com/file/Dark-Souls/Boss_0024_Gwyn%20Lord%20of%20Cinder.jpg",
                            Location = "Kiln of the First Flame",
                            Souls = 70000
                        },
                        new
                        {
                            Id = "8ec60d2a-946d-4d22-971e-a9fc423e7342",
                            BossName = "Ornstein",
                            Defense = 100,
                            Game_Id = 3,
                            Hp = 1642,
                            Image = "https://darksouls.wiki.fextralife.com/file/Dark-Souls/tumblr_lxlmomDlzY1qgjlhf.jpg",
                            Location = "Anor Londo",
                            Souls = 50000
                        },
                        new
                        {
                            Id = "92347543-2a10-40a1-8b0f-850d39fd20c0",
                            BossName = "Nashandra",
                            Defense = 135,
                            Game_Id = 4,
                            Hp = 8770,
                            Image = "https://darksouls2.wiki.fextralife.com/file/Dark-Souls-2/nashandra.png",
                            Location = "Throne of Want",
                            Souls = 90000
                        },
                        new
                        {
                            Id = "82f0b6a9-e802-407e-8c04-5e1933d8cfea",
                            BossName = "The Pursuer",
                            Defense = 123,
                            Game_Id = 4,
                            Hp = 3500,
                            Image = "https://darksouls2.wiki.fextralife.com/file/Dark-Souls-2/pursuer.png",
                            Location = "Forest of Fallen Giants",
                            Souls = 17000
                        },
                        new
                        {
                            Id = "b7ba2f00-749b-4189-8209-f9b21b3993ff",
                            BossName = "Soul of Cinder",
                            Defense = 150,
                            Game_Id = 5,
                            Hp = 10766,
                            Image = "https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/tumblr_o25lubbSXv1qzwtdlo1_1280.jpg",
                            Location = "Kiln of the First Flame",
                            Souls = 100000
                        },
                        new
                        {
                            Id = "58bdbf8d-934b-4a73-b3ab-cb7f46ef4c34",
                            BossName = "Pontiff Sulyvahn",
                            Defense = 107,
                            Game_Id = 5,
                            Hp = 5106,
                            Image = "https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/pontiff_sulyvahn_trophy.PNG",
                            Location = "Irithyll of the Boreal Valley",
                            Souls = 28000
                        },
                        new
                        {
                            Id = "c7145a87-1260-4ef1-a9a1-7e31a93aca74",
                            BossName = "Isshin, the Sword Saint",
                            Defense = 700,
                            Game_Id = 6,
                            Hp = 10000,
                            Image = "https://sekiroshadowsdietwice.wiki.fextralife.com/file/Sekiro-Shadows-Die-Twice/isshin-sword-saint-boss-sekiro-wiki-guide-300px.png",
                            Location = "Ashina Castle",
                            Souls = 2000
                        },
                        new
                        {
                            Id = "ec1de4a3-39e8-4bd7-8f51-cbc167945cb7",
                            BossName = "Genichiro Ashina",
                            Defense = 600,
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
