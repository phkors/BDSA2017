﻿// <auto-generated />
using BDSA2017.Lecture07.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace BDSA2017.Lecture07.Entities.Migrations
{
    [DbContext(typeof(FuturamaContext))]
    [Migration("20171012085119_InitialMigrationDammit")]
    partial class InitialMigrationDammit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BDSA2017.Lecture07.Entities.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("BDSA2017.Lecture07.Entities.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ActorId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Planet")
                        .HasMaxLength(50);

                    b.Property<string>("Species")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("ActorId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("BDSA2017.Lecture07.Entities.Episode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("FirstAired");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Episodes");
                });

            modelBuilder.Entity("BDSA2017.Lecture07.Entities.EpisodeCharacter", b =>
                {
                    b.Property<int>("EpisodeId");

                    b.Property<int>("CharacterId");

                    b.HasKey("EpisodeId", "CharacterId");

                    b.HasIndex("CharacterId");

                    b.ToTable("EpisodeCharacters");
                });

            modelBuilder.Entity("BDSA2017.Lecture07.Entities.Character", b =>
                {
                    b.HasOne("BDSA2017.Lecture07.Entities.Actor", "Actor")
                        .WithMany("Characters")
                        .HasForeignKey("ActorId");
                });

            modelBuilder.Entity("BDSA2017.Lecture07.Entities.EpisodeCharacter", b =>
                {
                    b.HasOne("BDSA2017.Lecture07.Entities.Character", "Characters")
                        .WithMany("Episodes")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BDSA2017.Lecture07.Entities.Episode", "Episode")
                        .WithMany("Characters")
                        .HasForeignKey("EpisodeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
