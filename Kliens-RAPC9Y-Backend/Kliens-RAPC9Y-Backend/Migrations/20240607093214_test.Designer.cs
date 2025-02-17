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
    [Migration("20240607093214_test")]
    partial class test
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

                    b.Property<bool>("Defeated")
                        .HasColumnType("bit");

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
                            Id = "13164059-3f20-413d-a9f9-4d65394d631a",
                            BossName = "Margit the Fell Omen",
                            Defeated = true,
                            Defense = 103,
                            Game_Id = 1,
                            Hp = 4074,
                            Image = "https://eldenring.wiki.fextralife.com/file/Elden-Ring/margit-1-boss-elden-ring-wiki.jpg",
                            Location = "Stormveil Castle",
                            Souls = 12000
                        },
                        new
                        {
                            Id = "1f2a80ce-d103-4faa-b65b-09f5a0b8629b",
                            BossName = "Godrick the Grafted",
                            Defeated = true,
                            Defense = 105,
                            Game_Id = 1,
                            Hp = 6080,
                            Image = "https://eldenring.wiki.fextralife.com/file/Elden-Ring/godrick_the_grafted_bosses_elden_ring_wiki_600px1-min.jpg",
                            Location = "Stormveil Castle",
                            Souls = 20000
                        },
                        new
                        {
                            Id = "42c48104-2494-4071-9ab2-b33038137b2f",
                            BossName = "Red Wolf of Radagon",
                            Defeated = false,
                            Defense = 107,
                            Game_Id = 1,
                            Hp = 2204,
                            Image = "https://eldenring.wiki.fextralife.com/file/Elden-Ring/red-wolf-of-radagon-2-elden-ring-wiki-guide.jpg",
                            Location = "Raya Lucaria Academy",
                            Souls = 14000
                        },
                        new
                        {
                            Id = "0aed0e50-7ab6-467d-83ac-d89a9cc07395",
                            BossName = "Rennala, Queen of the Full Moon",
                            Defeated = false,
                            Defense = 109,
                            Game_Id = 1,
                            Hp = 40000,
                            Image = "https://eldenring.wiki.fextralife.com/file/Elden-Ring/rennala_queen_of_the_full_moon_bosses_elden_ring_wiki_600px1-min.jpg",
                            Location = "Raya Lucaria Academy",
                            Souls = 700
                        },
                        new
                        {
                            Id = "a1c86678-53d5-4e04-b69b-92e2ec6d62d9",
                            BossName = "Leonine Misbegotten",
                            Defeated = true,
                            Defense = 104,
                            Game_Id = 1,
                            Hp = 2198,
                            Image = "https://eldenring.wiki.fextralife.com/file/Elden-Ring/leonine_misbegotten_bosses_elden_ring_wiki_600px1.jpg",
                            Location = "Castle Morne",
                            Souls = 3800
                        },
                        new
                        {
                            Id = "992b3cb5-0bb7-4403-aa14-51cbe0ca69e7",
                            BossName = "Father Gascoigne",
                            Defeated = false,
                            Defense = 95,
                            Game_Id = 2,
                            Hp = 2031,
                            Image = "https://bloodborne.wiki.fextralife.com/file/Bloodborne/father_gascoigne_boss.jpg",
                            Location = "Central Yharnam",
                            Souls = 1800
                        },
                        new
                        {
                            Id = "537845a8-56a2-46dd-aafd-6a92572be024",
                            BossName = "Gehrman, The First Hunter",
                            Defeated = false,
                            Defense = 150,
                            Game_Id = 2,
                            Hp = 14293,
                            Image = "https://bloodborne.wiki.fextralife.com/file/Bloodborne/gehrman_boss.jpg",
                            Location = "Hunter's Dream",
                            Souls = 128000
                        },
                        new
                        {
                            Id = "22dbffc0-c436-4d26-90a5-b13c4c0f4967",
                            BossName = "Gwyn, Lord of Cinder",
                            Defeated = false,
                            Defense = 120,
                            Game_Id = 3,
                            Hp = 4250,
                            Image = "https://darksouls.wiki.fextralife.com/file/Dark-Souls/Boss_0024_Gwyn%20Lord%20of%20Cinder.jpg",
                            Location = "Kiln of the First Flame",
                            Souls = 70000
                        },
                        new
                        {
                            Id = "a0e5c7a0-3686-4a28-8b7d-2843a15b733a",
                            BossName = "Ornstein",
                            Defeated = false,
                            Defense = 100,
                            Game_Id = 3,
                            Hp = 1642,
                            Image = "https://darksouls.wiki.fextralife.com/file/Dark-Souls/tumblr_lxlmomDlzY1qgjlhf.jpg",
                            Location = "Anor Londo",
                            Souls = 50000
                        },
                        new
                        {
                            Id = "0bd0573f-f431-43ee-95f8-d364758dd8eb",
                            BossName = "Nashandra",
                            Defeated = false,
                            Defense = 135,
                            Game_Id = 4,
                            Hp = 8770,
                            Image = "https://darksouls2.wiki.fextralife.com/file/Dark-Souls-2/nashandra.png",
                            Location = "Throne of Want",
                            Souls = 90000
                        },
                        new
                        {
                            Id = "452bd7c9-64e8-49eb-9931-6bd56d85e575",
                            BossName = "The Pursuer",
                            Defeated = false,
                            Defense = 123,
                            Game_Id = 4,
                            Hp = 3500,
                            Image = "https://darksouls2.wiki.fextralife.com/file/Dark-Souls-2/pursuer.png",
                            Location = "Forest of Fallen Giants",
                            Souls = 17000
                        },
                        new
                        {
                            Id = "dfbd7b32-2d9a-4cf2-86d7-cb591159db85",
                            BossName = "Soul of Cinder",
                            Defeated = false,
                            Defense = 150,
                            Game_Id = 5,
                            Hp = 10766,
                            Image = "https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/tumblr_o25lubbSXv1qzwtdlo1_1280.jpg",
                            Location = "Kiln of the First Flame",
                            Souls = 100000
                        },
                        new
                        {
                            Id = "3e45d52a-1d68-44ae-b4db-d57e97795a29",
                            BossName = "Pontiff Sulyvahn",
                            Defeated = false,
                            Defense = 107,
                            Game_Id = 5,
                            Hp = 5106,
                            Image = "https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/pontiff_sulyvahn_trophy.PNG",
                            Location = "Irithyll of the Boreal Valley",
                            Souls = 28000
                        },
                        new
                        {
                            Id = "25c2ca8a-7677-4ace-9f2a-7a9c9a278563",
                            BossName = "Isshin, the Sword Saint",
                            Defeated = false,
                            Defense = 700,
                            Game_Id = 6,
                            Hp = 10000,
                            Image = "https://sekiroshadowsdietwice.wiki.fextralife.com/file/Sekiro-Shadows-Die-Twice/isshin-sword-saint-boss-sekiro-wiki-guide-300px.png",
                            Location = "Ashina Castle",
                            Souls = 2000
                        },
                        new
                        {
                            Id = "9db9b94d-c87b-4ab8-80e5-cbcccd29c917",
                            BossName = "Genichiro Ashina",
                            Defeated = false,
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
