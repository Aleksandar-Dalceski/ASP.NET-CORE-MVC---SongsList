﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SongsList.Models;

namespace SongsList.Migrations
{
    [DbContext(typeof(SongContext))]
    [Migration("20210304175617_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SongsList.Models.Genre", b =>
                {
                    b.Property<string>("GenreId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            GenreId = "M",
                            Name = "Metal"
                        },
                        new
                        {
                            GenreId = "R",
                            Name = "Rap"
                        },
                        new
                        {
                            GenreId = "H",
                            Name = "Hip Hop"
                        },
                        new
                        {
                            GenreId = "RC",
                            Name = "Rock"
                        });
                });

            modelBuilder.Entity("SongsList.Models.Song", b =>
                {
                    b.Property<int>("SongId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GenreId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Rating")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("Year")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("SongId");

                    b.HasIndex("GenreId");

                    b.ToTable("Songs");

                    b.HasData(
                        new
                        {
                            SongId = 1,
                            GenreId = "M",
                            Name = "Master of Puppets",
                            Rating = 5,
                            Year = 1980
                        },
                        new
                        {
                            SongId = 2,
                            GenreId = "RC",
                            Name = "Wonderwall",
                            Rating = 4,
                            Year = 1990
                        },
                        new
                        {
                            SongId = 3,
                            GenreId = "R",
                            Name = "Lose Yourself",
                            Rating = 1,
                            Year = 2005
                        });
                });

            modelBuilder.Entity("SongsList.Models.Song", b =>
                {
                    b.HasOne("SongsList.Models.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
