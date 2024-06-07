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
    [Migration("20240607090507_userBossList")]
    partial class userBossList
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
                            Id = "8f1ce319-dd0f-468f-9461-ad9dbd9de136",
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
                            Id = "cdd68fd3-fa61-4fb4-8b93-e8596788509d",
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
                            Id = "3e4eb83b-8ae7-470a-afc4-759e452f1c0a",
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
                            Id = "28d185da-367b-4441-ac88-f3c28f581fd7",
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
                            Id = "498e0829-386a-4c75-ae5c-b7e288e03ed1",
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
                            Id = "82c65bc2-ae08-4158-b158-5092e7f2e21a",
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
                            Id = "dcec86b2-068d-4978-b1fb-5537c4239e30",
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
                            Id = "32b177e1-1932-431d-bd78-1aa6944c58af",
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
                            Id = "339d555b-2ca1-4d59-a8a7-e7b40589d0c0",
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
                            Id = "0a62d641-a5c5-4109-82da-8b748b5e329a",
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
                            Id = "39fe4b5e-29ef-4855-ae9f-c5a3f84207bf",
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
                            Id = "04d88467-5cd2-4e99-bc39-7db9a8e8c22e",
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
                            Id = "90ee3f72-e5e8-4c3b-8010-ea2c69e004fa",
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
                            Id = "601016d4-3bad-4bd4-9e60-31dc09f5e521",
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
                            Id = "8f8e444d-6a78-4b9c-bf26-d224491ad799",
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
