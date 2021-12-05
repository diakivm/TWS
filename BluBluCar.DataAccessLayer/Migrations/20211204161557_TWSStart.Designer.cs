﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TWS.DataAccessLayer.TWSContext;

#nullable disable

namespace TWS.DataAccessLayer.Migrations
{
    [DbContext(typeof(TWSDBContext))]
    [Migration("20211204161557_TWSStart")]
    partial class TWSStart
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TWS.DataAccessLayer.Entities.DriverAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DriverExperience")
                        .HasColumnType("int");

                    b.Property<int>("UserAccountForeignKey")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserAccountForeignKey")
                        .IsUnique();

                    b.ToTable("DriverAccounts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DriverExperience = 20,
                            UserAccountForeignKey = 1
                        },
                        new
                        {
                            Id = 2,
                            DriverExperience = 5,
                            UserAccountForeignKey = 2
                        });
                });

            modelBuilder.Entity("TWS.DataAccessLayer.Entities.Transport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CarBrand")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CarModel")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("DriverAccountForeignKey")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfSeats")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DriverAccountForeignKey")
                        .IsUnique();

                    b.ToTable("Transports");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CarBrand = "BMW",
                            CarModel = "X5",
                            DriverAccountForeignKey = 1,
                            NumberOfSeats = 3
                        },
                        new
                        {
                            Id = 2,
                            CarBrand = "Audi",
                            CarModel = "A7",
                            DriverAccountForeignKey = 2,
                            NumberOfSeats = 3
                        });
                });

            modelBuilder.Entity("TWS.DataAccessLayer.Entities.TravelerAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("TravelExperience")
                        .HasColumnType("int");

                    b.Property<int>("UserAccountForeignKey")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserAccountForeignKey")
                        .IsUnique();

                    b.ToTable("TravelerAccounts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            TravelExperience = 3,
                            UserAccountForeignKey = 3
                        },
                        new
                        {
                            Id = 2,
                            TravelExperience = 7,
                            UserAccountForeignKey = 4
                        });
                });

            modelBuilder.Entity("TWS.DataAccessLayer.Entities.Trip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("DriverAccountForeignKey")
                        .HasColumnType("int");

                    b.Property<byte>("NumberOfFreeSeats")
                        .HasColumnType("tinyint");

                    b.Property<string>("PlaceOfArrival")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PlaceOfDeparture")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("TimeOfArrival")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeOfDeparture")
                        .HasColumnType("datetime2");

                    b.Property<int?>("TravelerAccountForeignKey")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DriverAccountForeignKey");

                    b.HasIndex("TravelerAccountForeignKey");

                    b.ToTable("Trips");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DriverAccountForeignKey = 1,
                            NumberOfFreeSeats = (byte)1,
                            PlaceOfArrival = "Lviv",
                            PlaceOfDeparture = "Chernivtsi",
                            TimeOfArrival = new DateTime(2021, 12, 4, 21, 15, 56, 652, DateTimeKind.Local).AddTicks(259),
                            TimeOfDeparture = new DateTime(2021, 12, 4, 18, 15, 56, 615, DateTimeKind.Local).AddTicks(6967),
                            TravelerAccountForeignKey = 1
                        },
                        new
                        {
                            Id = 2,
                            DriverAccountForeignKey = 1,
                            NumberOfFreeSeats = (byte)3,
                            PlaceOfArrival = "Ivano-Frankivsk",
                            PlaceOfDeparture = "Lviv",
                            TimeOfArrival = new DateTime(2021, 12, 6, 21, 15, 56, 652, DateTimeKind.Local).AddTicks(1635),
                            TimeOfDeparture = new DateTime(2021, 12, 6, 18, 15, 56, 652, DateTimeKind.Local).AddTicks(1612)
                        },
                        new
                        {
                            Id = 3,
                            DriverAccountForeignKey = 2,
                            NumberOfFreeSeats = (byte)3,
                            PlaceOfArrival = "Kyiw",
                            PlaceOfDeparture = "Odessa",
                            TimeOfArrival = new DateTime(2021, 12, 6, 18, 15, 56, 652, DateTimeKind.Local).AddTicks(1642),
                            TimeOfDeparture = new DateTime(2021, 12, 5, 18, 15, 56, 652, DateTimeKind.Local).AddTicks(1640)
                        });
                });

            modelBuilder.Entity("TWS.DataAccessLayer.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfRegistration")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasComputedColumnSql("GETDATE()");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)")
                        .HasDefaultValue("None");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfBirth = new DateTime(1971, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfRegistration = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Chris",
                            Gender = "male",
                            LastName = "Evans",
                            PhoneNumber = "+380965433214"
                        },
                        new
                        {
                            Id = 2,
                            DateOfBirth = new DateTime(1978, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfRegistration = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Johny",
                            Gender = "male",
                            LastName = "Depp",
                            PhoneNumber = "+380965433463"
                        },
                        new
                        {
                            Id = 3,
                            DateOfBirth = new DateTime(1969, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfRegistration = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Will",
                            Gender = "male",
                            LastName = "Smith",
                            PhoneNumber = "+380965437645"
                        },
                        new
                        {
                            Id = 4,
                            DateOfBirth = new DateTime(1969, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfRegistration = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Robert",
                            Gender = "male",
                            LastName = "Downey",
                            PhoneNumber = "+380965433421"
                        },
                        new
                        {
                            Id = 5,
                            DateOfBirth = new DateTime(1985, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfRegistration = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Keanu",
                            Gender = "male",
                            LastName = "Reevs",
                            PhoneNumber = "+380965454374"
                        });
                });

            modelBuilder.Entity("TWS.DataAccessLayer.Entities.DriverAccount", b =>
                {
                    b.HasOne("TWS.DataAccessLayer.Entities.User", "UserAccount")
                        .WithOne("DriverAccount")
                        .HasForeignKey("TWS.DataAccessLayer.Entities.DriverAccount", "UserAccountForeignKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserAccount");
                });

            modelBuilder.Entity("TWS.DataAccessLayer.Entities.Transport", b =>
                {
                    b.HasOne("TWS.DataAccessLayer.Entities.DriverAccount", "DriverAccount")
                        .WithOne("Transport")
                        .HasForeignKey("TWS.DataAccessLayer.Entities.Transport", "DriverAccountForeignKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DriverAccount");
                });

            modelBuilder.Entity("TWS.DataAccessLayer.Entities.TravelerAccount", b =>
                {
                    b.HasOne("TWS.DataAccessLayer.Entities.User", "UserAccount")
                        .WithOne("TravelerAccount")
                        .HasForeignKey("TWS.DataAccessLayer.Entities.TravelerAccount", "UserAccountForeignKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserAccount");
                });

            modelBuilder.Entity("TWS.DataAccessLayer.Entities.Trip", b =>
                {
                    b.HasOne("TWS.DataAccessLayer.Entities.DriverAccount", "DriverAccount")
                        .WithMany("PublishedTrips")
                        .HasForeignKey("DriverAccountForeignKey");

                    b.HasOne("TWS.DataAccessLayer.Entities.TravelerAccount", "TravelerAccount")
                        .WithMany("PlannedTrips")
                        .HasForeignKey("TravelerAccountForeignKey");

                    b.Navigation("DriverAccount");

                    b.Navigation("TravelerAccount");
                });

            modelBuilder.Entity("TWS.DataAccessLayer.Entities.DriverAccount", b =>
                {
                    b.Navigation("PublishedTrips");

                    b.Navigation("Transport")
                        .IsRequired();
                });

            modelBuilder.Entity("TWS.DataAccessLayer.Entities.TravelerAccount", b =>
                {
                    b.Navigation("PlannedTrips");
                });

            modelBuilder.Entity("TWS.DataAccessLayer.Entities.User", b =>
                {
                    b.Navigation("DriverAccount")
                        .IsRequired();

                    b.Navigation("TravelerAccount")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
