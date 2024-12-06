﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _8_1_TripLog.Data;

#nullable disable

namespace _8_1_TripLog.Migrations
{
    [DbContext(typeof(TripLogContext))]
    [Migration("20241206070638_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("_8_1_TripLog.Models.Trip", b =>
                {
                    b.Property<int>("TripId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TripId"));

                    b.Property<string>("Accommodation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccommodationEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccommodationPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ThingToDo1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThingToDo2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThingToDo3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TripId");

                    b.ToTable("Trips");

                    b.HasData(
                        new
                        {
                            TripId = 1,
                            Accommodation = "My Car",
                            AccommodationEmail = "LowMoney@Mazda.com",
                            AccommodationPhone = "123-456-7890",
                            Destination = "Washington",
                            EndDate = new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ThingToDo1 = "Drive",
                            ThingToDo2 = "Eat",
                            ThingToDo3 = "Look at stuff"
                        },
                        new
                        {
                            TripId = 2,
                            Accommodation = "Sleep Number Store",
                            AccommodationEmail = "info@sleepnumber.com",
                            AccommodationPhone = "987-654-3210",
                            Destination = "Hawaii",
                            EndDate = new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ThingToDo1 = "Go To Beach",
                            ThingToDo2 = "Go To Volcano",
                            ThingToDo3 = "Karaoke"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
