﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnionExample.Application.Context;

#nullable disable

namespace OnionExample.Application.Migrations
{
    [DbContext(typeof(OnionDbContext))]
    [Migration("20221126114529_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("OnionExample.Domain.Models.MovieModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("MovieName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("MovieReleaseDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("MovieModels");
                });

            modelBuilder.Entity("OnionExample.Domain.Models.MovieSessionsModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("MovieSessionExpire")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("MovieSessionStart")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("SalloonModelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SalloonModelId");

                    b.ToTable("MovieSessionsModels");
                });

            modelBuilder.Entity("OnionExample.Domain.Models.SalloonModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("MovieModelId")
                        .HasColumnType("int");

                    b.Property<string>("SalloonName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("MovieModelId");

                    b.ToTable("SalloonModels");
                });

            modelBuilder.Entity("OnionExample.Domain.Models.MovieSessionsModel", b =>
                {
                    b.HasOne("OnionExample.Domain.Models.SalloonModel", "SalloonModel")
                        .WithMany("MovieSessionsModels")
                        .HasForeignKey("SalloonModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SalloonModel");
                });

            modelBuilder.Entity("OnionExample.Domain.Models.SalloonModel", b =>
                {
                    b.HasOne("OnionExample.Domain.Models.MovieModel", "MovieModel")
                        .WithMany("Salloons")
                        .HasForeignKey("MovieModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MovieModel");
                });

            modelBuilder.Entity("OnionExample.Domain.Models.MovieModel", b =>
                {
                    b.Navigation("Salloons");
                });

            modelBuilder.Entity("OnionExample.Domain.Models.SalloonModel", b =>
                {
                    b.Navigation("MovieSessionsModels");
                });
#pragma warning restore 612, 618
        }
    }
}
