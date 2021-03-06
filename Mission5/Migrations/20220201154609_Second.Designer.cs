// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission5.Models;

namespace Mission5.Migrations
{
    [DbContext(typeof(MovieContext))]
    [Migration("20220201154609_Second")]
    partial class Second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Mission5.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Adventure"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Family"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Romance"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Horror"
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryName = "Drama"
                        },
                        new
                        {
                            CategoryId = 7,
                            CategoryName = "Musical"
                        });
                });

            modelBuilder.Entity("Mission5.Models.FormResponse", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Edited")
                        .HasColumnType("TEXT");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MovieId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            CategoryId = 3,
                            Director = "Gary Winick",
                            Edited = "true",
                            LentTo = "Cami",
                            Notes = "My favorite romcom",
                            Rating = "PG-13",
                            Title = "13 Going on 30",
                            Year = "2004"
                        },
                        new
                        {
                            MovieId = 2,
                            CategoryId = 1,
                            Director = "Joss Whedon",
                            Edited = "false",
                            LentTo = "Spencer",
                            Notes = "So funny",
                            Rating = "PG-13",
                            Title = "The Avengers",
                            Year = "2012"
                        },
                        new
                        {
                            MovieId = 3,
                            CategoryId = 2,
                            Director = "Nathan Greno",
                            Edited = "false",
                            LentTo = "Elena",
                            Notes = "Best Princess Movie",
                            Rating = "PG",
                            Title = "Tangled",
                            Year = "2010"
                        });
                });

            modelBuilder.Entity("Mission5.Models.FormResponse", b =>
                {
                    b.HasOne("Mission5.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
