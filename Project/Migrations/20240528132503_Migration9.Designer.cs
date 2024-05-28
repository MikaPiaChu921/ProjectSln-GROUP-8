﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project.Contexts;

#nullable disable

namespace Project.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20240528132503_Migration9")]
    partial class Migration9
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Project.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customer");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            Address = "Talisay City",
                            FullName = "Pia Admin"
                        },
                        new
                        {
                            CustomerId = 2,
                            Address = "Cebu City",
                            FullName = "User Admin"
                        });
                });

            modelBuilder.Entity("Project.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<int?>("OrdersId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("OrdersId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Project.Models.Orders", b =>
                {
                    b.Property<int>("OrdersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrdersId"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.HasKey("OrdersId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Project.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Description = "Joyce Ice Cream",
                            Name = "Ice Cream",
                            Price = 10.0,
                            RestaurantId = 1,
                            Stock = 999
                        },
                        new
                        {
                            ProductId = 2,
                            Description = "Masarap",
                            Name = "Lollipop",
                            Price = 2.0,
                            RestaurantId = 1,
                            Stock = 500
                        },
                        new
                        {
                            ProductId = 3,
                            Description = "Lasagna",
                            Name = "Spaghetti",
                            Price = 10.0,
                            RestaurantId = 2,
                            Stock = 200
                        },
                        new
                        {
                            ProductId = 4,
                            Description = "jollibee, Mcdo and kfc",
                            Name = "Chiken",
                            Price = 140.0,
                            RestaurantId = 2,
                            Stock = 200
                        },
                        new
                        {
                            ProductId = 5,
                            Description = "yum, big mac, 4 cheese woper",
                            Name = "Burger",
                            Price = 150.0,
                            RestaurantId = 3,
                            Stock = 200
                        },
                        new
                        {
                            ProductId = 6,
                            Description = "white, dark and milk",
                            Name = "chocolate",
                            Price = 100.0,
                            RestaurantId = 3,
                            Stock = 200
                        });
                });

            modelBuilder.Entity("Project.Models.Reservation", b =>
                {
                    b.Property<int>("ReservationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReservationId"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReservationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.HasKey("ReservationId");

                    b.ToTable("Reservation");
                });

            modelBuilder.Entity("Project.Models.Restaurant", b =>
                {
                    b.Property<int>("RestaurantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RestaurantId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Locaton")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RestaurantId");

                    b.ToTable("Restaurant");

                    b.HasData(
                        new
                        {
                            RestaurantId = 1,
                            Description = "Enjoy nice food",
                            Locaton = "Tabunok",
                            Name = "Pia Restobar"
                        },
                        new
                        {
                            RestaurantId = 2,
                            Description = "Enjoy nice food",
                            Locaton = "San Isidro",
                            Name = "Jayharron"
                        },
                        new
                        {
                            RestaurantId = 3,
                            Description = "Enjoy nice food",
                            Locaton = "Tisa",
                            Name = "Aubrey"
                        });
                });

            modelBuilder.Entity("Project.Models.Order", b =>
                {
                    b.HasOne("Project.Models.Orders", null)
                        .WithMany("OrdersList")
                        .HasForeignKey("OrdersId");
                });

            modelBuilder.Entity("Project.Models.Orders", b =>
                {
                    b.Navigation("OrdersList");
                });
#pragma warning restore 612, 618
        }
    }
}
