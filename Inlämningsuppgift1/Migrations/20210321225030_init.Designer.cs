﻿// <auto-generated />
using Inlämningsuppgift1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Inlämningsuppgift1.Migrations
{
    [DbContext(typeof(eventsDbContext))]
    [Migration("20210321225030_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Inlämningsuppgift1.Models.Event", b =>
                {
                    b.Property<int>("eventID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("date")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("organizer_id")
                        .HasColumnType("int");

                    b.Property<string>("place")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("spots_available")
                        .HasColumnType("int");

                    b.HasKey("eventID");

                    b.ToTable("Event");
                });
#pragma warning restore 612, 618
        }
    }
}
