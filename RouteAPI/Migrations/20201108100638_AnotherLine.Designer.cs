﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RouteAPI.Data;

namespace RouteAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201108100638_AnotherLine")]
    partial class AnotherLine
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RouteAPI.Models.Coordinate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LineId")
                        .HasColumnType("int");

                    b.Property<double>("XCoordinate")
                        .HasColumnType("float");

                    b.Property<double>("YCoordinate")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("LineId");

                    b.ToTable("Coordinates");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LineId = 1,
                            XCoordinate = 45.248882999999999,
                            YCoordinate = 19.791696999999999
                        },
                        new
                        {
                            Id = 2,
                            LineId = 1,
                            XCoordinate = 45.253169999999997,
                            YCoordinate = 19.804231999999999
                        },
                        new
                        {
                            Id = 3,
                            LineId = 1,
                            XCoordinate = 45.248804999999997,
                            YCoordinate = 19.807176999999999
                        },
                        new
                        {
                            Id = 4,
                            LineId = 1,
                            XCoordinate = 45.247568999999999,
                            YCoordinate = 19.807628000000001
                        },
                        new
                        {
                            Id = 5,
                            LineId = 1,
                            XCoordinate = 45.248596999999997,
                            YCoordinate = 19.816578
                        },
                        new
                        {
                            Id = 6,
                            LineId = 1,
                            XCoordinate = 45.249366999999999,
                            YCoordinate = 19.822073
                        },
                        new
                        {
                            Id = 7,
                            LineId = 1,
                            XCoordinate = 45.249139999999997,
                            YCoordinate = 19.830935
                        },
                        new
                        {
                            Id = 8,
                            LineId = 1,
                            XCoordinate = 45.254322000000002,
                            YCoordinate = 19.842607999999998
                        },
                        new
                        {
                            Id = 9,
                            LineId = 1,
                            XCoordinate = 45.254877,
                            YCoordinate = 19.841878999999999
                        },
                        new
                        {
                            Id = 10,
                            LineId = 2,
                            XCoordinate = 45.236991000000003,
                            YCoordinate = 19.826449
                        },
                        new
                        {
                            Id = 11,
                            LineId = 2,
                            XCoordinate = 45.238233000000001,
                            YCoordinate = 19.830770999999999
                        },
                        new
                        {
                            Id = 12,
                            LineId = 2,
                            XCoordinate = 45.239184999999999,
                            YCoordinate = 19.834212999999998
                        },
                        new
                        {
                            Id = 13,
                            LineId = 2,
                            XCoordinate = 45.239604999999997,
                            YCoordinate = 19.835805000000001
                        },
                        new
                        {
                            Id = 14,
                            LineId = 2,
                            XCoordinate = 45.241639999999997,
                            YCoordinate = 19.842815999999999
                        },
                        new
                        {
                            Id = 15,
                            LineId = 2,
                            XCoordinate = 45.244140000000002,
                            YCoordinate = 19.841380999999998
                        },
                        new
                        {
                            Id = 16,
                            LineId = 2,
                            XCoordinate = 45.246419000000003,
                            YCoordinate = 19.840147999999999
                        },
                        new
                        {
                            Id = 17,
                            LineId = 2,
                            XCoordinate = 45.247973999999999,
                            YCoordinate = 19.839265000000001
                        },
                        new
                        {
                            Id = 18,
                            LineId = 2,
                            XCoordinate = 45.24774,
                            YCoordinate = 19.836482
                        },
                        new
                        {
                            Id = 19,
                            LineId = 2,
                            XCoordinate = 45.248657999999999,
                            YCoordinate = 19.833655
                        },
                        new
                        {
                            Id = 20,
                            LineId = 2,
                            XCoordinate = 45.249699999999997,
                            YCoordinate = 19.832616000000002
                        },
                        new
                        {
                            Id = 21,
                            LineId = 2,
                            XCoordinate = 45.249217999999999,
                            YCoordinate = 19.830915999999998
                        },
                        new
                        {
                            Id = 22,
                            LineId = 2,
                            XCoordinate = 45.249294999999996,
                            YCoordinate = 19.824555
                        },
                        new
                        {
                            Id = 23,
                            LineId = 2,
                            XCoordinate = 45.248145000000001,
                            YCoordinate = 19.824997
                        },
                        new
                        {
                            Id = 24,
                            LineId = 2,
                            XCoordinate = 45.245547999999999,
                            YCoordinate = 19.825106999999999
                        },
                        new
                        {
                            Id = 25,
                            LineId = 2,
                            XCoordinate = 45.243386000000001,
                            YCoordinate = 19.825240000000001
                        },
                        new
                        {
                            Id = 26,
                            LineId = 2,
                            XCoordinate = 45.239845000000003,
                            YCoordinate = 19.825330999999998
                        },
                        new
                        {
                            Id = 27,
                            LineId = 2,
                            XCoordinate = 45.238531999999999,
                            YCoordinate = 19.825835000000001
                        },
                        new
                        {
                            Id = 28,
                            LineId = 2,
                            XCoordinate = 45.237127000000001,
                            YCoordinate = 19.826509999999999
                        });
                });

            modelBuilder.Entity("RouteAPI.Models.Departure", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.Property<int>("TimetableId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TimetableId");

                    b.ToTable("Departures");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Time = new DateTime(2020, 10, 23, 8, 45, 0, 0, DateTimeKind.Unspecified),
                            TimetableId = 1
                        },
                        new
                        {
                            Id = 2,
                            Time = new DateTime(2020, 10, 23, 9, 45, 0, 0, DateTimeKind.Unspecified),
                            TimetableId = 1
                        },
                        new
                        {
                            Id = 3,
                            Time = new DateTime(2020, 10, 23, 10, 45, 0, 0, DateTimeKind.Unspecified),
                            TimetableId = 1
                        });
                });

            modelBuilder.Entity("RouteAPI.Models.Line", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Lines");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "2",
                            Type = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "3",
                            Type = 1
                        });
                });

            modelBuilder.Entity("RouteAPI.Models.LineStation", b =>
                {
                    b.Property<int>("LineId")
                        .HasColumnType("int");

                    b.Property<int>("StationId")
                        .HasColumnType("int");

                    b.HasKey("LineId", "StationId");

                    b.HasIndex("StationId");

                    b.ToTable("LineStations");

                    b.HasData(
                        new
                        {
                            LineId = 1,
                            StationId = 1
                        },
                        new
                        {
                            LineId = 1,
                            StationId = 2
                        },
                        new
                        {
                            LineId = 1,
                            StationId = 3
                        });
                });

            modelBuilder.Entity("RouteAPI.Models.Station", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("XCoordinate")
                        .HasColumnType("float");

                    b.Property<double>("YCoordinate")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Stations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Bul. Jovana Ducica",
                            Name = "Tri kule",
                            XCoordinate = 45.251052000000001,
                            YCoordinate = 19.798290999999999
                        },
                        new
                        {
                            Id = 2,
                            Address = "Futoska",
                            Name = "Higijenski zavod",
                            XCoordinate = 45.248686999999997,
                            YCoordinate = 19.817565999999999
                        },
                        new
                        {
                            Id = 3,
                            Address = "Uspenska",
                            Name = "Centar",
                            XCoordinate = 45.254818999999998,
                            YCoordinate = 19.841785000000002
                        });
                });

            modelBuilder.Entity("RouteAPI.Models.Timetable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<int>("DayType")
                        .HasColumnType("int");

                    b.Property<DateTime>("From")
                        .HasColumnType("datetime2");

                    b.Property<int>("LineId")
                        .HasColumnType("int");

                    b.Property<DateTime>("To")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("LineId");

                    b.ToTable("Timetables");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Active = true,
                            DayType = 1,
                            From = new DateTime(2020, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LineId = 1,
                            To = new DateTime(2020, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("RouteAPI.Models.Coordinate", b =>
                {
                    b.HasOne("RouteAPI.Models.Line", "Line")
                        .WithMany("Coordinates")
                        .HasForeignKey("LineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RouteAPI.Models.Departure", b =>
                {
                    b.HasOne("RouteAPI.Models.Timetable", "Timetable")
                        .WithMany("Departures")
                        .HasForeignKey("TimetableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RouteAPI.Models.LineStation", b =>
                {
                    b.HasOne("RouteAPI.Models.Line", "Line")
                        .WithMany("LineStations")
                        .HasForeignKey("LineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RouteAPI.Models.Station", "Station")
                        .WithMany("LineStations")
                        .HasForeignKey("StationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RouteAPI.Models.Timetable", b =>
                {
                    b.HasOne("RouteAPI.Models.Line", "Line")
                        .WithMany()
                        .HasForeignKey("LineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}