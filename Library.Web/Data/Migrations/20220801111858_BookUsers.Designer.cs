﻿// <auto-generated />
using System;
using Library.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Library.Web.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220801111858_BookUsers")]
    partial class BookUsers
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ApplicationUserBook", b =>
                {
                    b.Property<string>("PplWhoReadId")
                        .HasColumnType("text");

                    b.Property<int>("ReadBooksId")
                        .HasColumnType("integer");

                    b.HasKey("PplWhoReadId", "ReadBooksId");

                    b.HasIndex("ReadBooksId");

                    b.ToTable("ApplicationUserBook");
                });

            modelBuilder.Entity("Library.Web.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Library.Web.Data.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("Title");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            Description = "Eugene Onegin is the master work of the poet whom Russians regard as the fountainhead of their literature. Set in 1820s Russia, Pushkin's verse novel follows the fates of three men and three women. Engaging, full of suspense, and varied in tone, it also portrays a large cast of other characters and offers the reader many literary, philosophical, and autobiographical digressions, often in a highly satirical vein.",
                            Title = "Eugene Onegin"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 1,
                            Description = "Pushkin's version of the historical novel in the style of Walter Scott, this final prose work also reflects his fascination with and research into Russian history of the 18th century. During the reign of Catherine the Great, the young Grinev sets out for his new career in the army and en route performs an act of kindness by giving his warm coat to a man freezing in a blizzard. This action reaps its reward when he subsequently finds himself caught up in the rebellion headed by the infamous, and strangely familiar, Pugachev. Rivalry with a fellow officer for the affections of Captain Mironov's daughter further complicates Grinev's affairs, and ultimately it is only an appeal by Masha Mironova, the eponymous captain's daughter, to the Empress herself that can unravel a tangled web.",
                            Title = "The Captain's Daughter"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 1,
                            Description = "The Queen of Spades (Russian: Pikovaya dama) is an acclaimed short story by Alexander Pushkin about human avariciousness. Pushkin wrote the story in autumn 1833 in Boldino and it was first published in literary magazine Biblioteka dlya chteniya in 1834. It was turned into the opera The Queen of Spades by Tchaikovsky.",
                            Title = "The Queen of Spades"
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 2,
                            Description = "TheBazarov—a gifted, impatient, and caustic young man—has journeyed from school to the home of his friend Arkady Kirsanov. But soon Bazarov’s outspoken rejection of authority and social conventions touches off quarrels, misunderstandings, and romantic entanglements that will utterly transform the Kirsanov household and reflect the changes taking place across all of nineteenth-century Russia.",
                            Title = "Fathers and Sons"
                        },
                        new
                        {
                            Id = 5,
                            AuthorId = 2,
                            Description = "This vivid, sensitive tale of adolescent love follows a 16-year-old boy who falls in love with a beautiful, older woman and experiences a whirlwind of changing emotions, from exaltation and jealousy to despair and devotion. This beautifully packaged series of classic novellas includes the works of masterful writers. Inexpensive and collectible, they are the first single-volume publications of these classic tales, offering a closer look at this underappreciated literary form and providing a fresh take on the world's most celebrated authors.",
                            Title = "First Love"
                        },
                        new
                        {
                            Id = 6,
                            AuthorId = 2,
                            Description = "Mumu (Russian: «Муму») is a short story by Ivan Turgenev, a Russian novelist and story writer, written in 1854. The story of Gerasim, a deaf and mute serf whose life of poverty is brought into sharp relief by his connection with Mumu, a dog he rescued, brought greater national attention to the cruelties of serfdom, and received praise for its brutal portrayal of this institution in Russian society.",
                            Title = "Mumu"
                        },
                        new
                        {
                            Id = 7,
                            AuthorId = 3,
                            Description = "Raskolnikov, a destitute and desperate former student, wanders through the slums of St Petersburg and commits a random murder without remorse or regret. He imagines himself to be a great man, a Napoleon: acting for a higher purpose beyond conventional moral law. But as he embarks on a dangerous game of cat and mouse with a suspicious police investigator, Raskolnikov is pursued by the growing voice of his conscience and finds the noose of his own guilt tightening around his neck. Only Sonya, a downtrodden sex worker, can offer the chance of redemption.",
                            Title = "Crime and Punishment"
                        },
                        new
                        {
                            Id = 8,
                            AuthorId = 3,
                            Description = "The Brothers Karamazov is a murder mystery, a courtroom drama, and an exploration of erotic rivalry in a series of triangular love affairs involving the “wicked and sentimental” Fyodor Pavlovich Karamazov and his three sons―the impulsive and sensual Dmitri; the coldly rational Ivan; and the healthy, red-cheeked young novice Alyosha. Through the gripping events of their story, Dostoevsky portrays the whole of Russian life, is social and spiritual striving, in what was both the golden age and a tragic turning point in Russian culture.",
                            Title = "The Brothers Karamazov"
                        },
                        new
                        {
                            Id = 9,
                            AuthorId = 3,
                            Description = "Returning to Russia from a sanitarium in Switzerland, the Christ-like epileptic Prince Myshkin finds himself enmeshed in a tangle of love, torn between two women—the notorious kept woman Nastasya and the pure Aglaia—both involved, in turn, with the corrupt, money-hungry Ganya. In the end, Myshkin’s honesty, goodness, and integrity are shown to be unequal to the moral emptiness of those around him. In her revision of the Garnett translation, Anna Brailovsky has corrected inaccuracies wrought by Garnett’s drastic anglicization of the novel, restoring as much as possible the syntactical structure of the original story.",
                            Title = "The Idiot"
                        },
                        new
                        {
                            Id = 10,
                            AuthorId = 4,
                            Description = "Miss Blandish - innocent, exquisite, vulnerable heiress - is kidnapped by a gang of ruthless hoods who've never tried big-time crime. Foiled by their own vicious ineptitude and the greed of a superior mob, the kidnappers lose their million dollar prize. Blandish, terrified and broken, is now the captive of Ma' Grisson and her sadistic, sexually deviant son Slim.",
                            Title = "No Orchids for Miss Blandish"
                        },
                        new
                        {
                            Id = 11,
                            AuthorId = 4,
                            Description = "It was the easiest three grand Nelson Ryan had ever made - but suddenly he realized he was being played for a sucker. A telephone call, seemingly innocent enough, led him to the murder of a Chinese call-girl who'd talked too much. It also pitched him straight into the teeming, sordid night life of colourful Hong Kong.",
                            Title = "A Coffin from Hong Kong"
                        },
                        new
                        {
                            Id = 12,
                            AuthorId = 4,
                            Description = "Kahlenberg, millionaire and a compulsive collector of art treasures steals a famous poison ring, once owned by Caesar Borgia, from a rival collector. Kahlenberg's museum is hidden in the Drakensberg range and can only be reached through the dangerous swamps and the steamy heat of the Basutoland jungle.",
                            Title = "The Vulture Is a Patient Bird"
                        },
                        new
                        {
                            Id = 13,
                            AuthorId = 5,
                            Description = "Harry Potter's life is miserable. His parents are dead and he's stuck with his heartless relatives, who force him to live in a tiny closet under the stairs. But his fortune changes when he receives a letter that tells him the truth about himself: he's a wizard. A mysterious visitor rescues him from his relatives and takes him to his new home, Hogwarts School of Witchcraft and Wizardry.",
                            Title = "Harry Potter and the Sorcerer's Stone"
                        },
                        new
                        {
                            Id = 14,
                            AuthorId = 5,
                            Description = "Ever since Harry Potter had come home for the summer, the Dursleys had been so mean and hideous that all Harry wanted was to get back to the Hogwarts School for Witchcraft and Wizardry. But just as he’s packing his bags, Harry receives a warning from a strange impish creature who says that if Harry returns to Hogwarts, disaster will strike.",
                            Title = "Harry Potter and the Chamber of Secrets"
                        },
                        new
                        {
                            Id = 15,
                            AuthorId = 5,
                            Description = "During his third year at Hogwarts School for Witchcraft and Wizardry, Harry Potter must confront the devious and dangerous wizard responsible for his parents' deaths. ",
                            Title = "Harry Potter and the Prisoner of Azkaban"
                        });
                });

            modelBuilder.Entity("Library.Web.Data.Writer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.ToTable("Writers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Pushkin"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Turgenev"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Dostoevsky"
                        },
                        new
                        {
                            Id = 4,
                            Name = "James Chase"
                        },
                        new
                        {
                            Id = 5,
                            Name = "J. K. Rowling"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ApplicationUserBook", b =>
                {
                    b.HasOne("Library.Web.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("PplWhoReadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library.Web.Data.Book", null)
                        .WithMany()
                        .HasForeignKey("ReadBooksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Library.Web.Data.Book", b =>
                {
                    b.HasOne("Library.Web.Data.Writer", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
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
                    b.HasOne("Library.Web.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Library.Web.Data.ApplicationUser", null)
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

                    b.HasOne("Library.Web.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Library.Web.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Library.Web.Data.Writer", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}