﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Restaurant_Project;

#nullable disable

namespace Restaurant_Project.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240508165330_finalMigration")]
    partial class finalMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FoodrinkOrder", b =>
                {
                    b.Property<int>("foodrinksId")
                        .HasColumnType("int");

                    b.Property<int>("ordersId")
                        .HasColumnType("int");

                    b.HasKey("foodrinksId", "ordersId");

                    b.HasIndex("ordersId");

                    b.ToTable("FoodrinkOrder");
                });

            modelBuilder.Entity("Restaurant_Project.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "cold drink"
                        },
                        new
                        {
                            Id = 2,
                            Name = "hot drink"
                        },
                        new
                        {
                            Id = 3,
                            Name = "main meal"
                        },
                        new
                        {
                            Id = 4,
                            Name = "treat"
                        });
                });

            modelBuilder.Entity("Restaurant_Project.Models.Employer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("employers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "jesr al-abiad",
                            Age = 22,
                            Name = "Ahmed Jalal",
                            Phone = "0947675777"
                        },
                        new
                        {
                            Id = 2,
                            Address = "afif",
                            Age = 23,
                            Name = "Emad Khayat",
                            Phone = "0933431567"
                        },
                        new
                        {
                            Id = 3,
                            Address = "midan",
                            Age = 19,
                            Name = "Bilal Tahan",
                            Phone = "0968793347"
                        },
                        new
                        {
                            Id = 4,
                            Address = "shaghour",
                            Age = 33,
                            Name = "Bahaa Nahas",
                            Phone = "0928139925"
                        });
                });

            modelBuilder.Entity("Restaurant_Project.Models.Foodrink", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("foodrinks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 4,
                            Name = "cheese cake",
                            Price = 200.0,
                            Quantity = 100
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 3,
                            Name = "chicken",
                            Price = 250.0,
                            Quantity = 80
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Name = "cola",
                            Price = 50.0,
                            Quantity = 400
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Name = "coffee",
                            Price = 70.0,
                            Quantity = 500
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 3,
                            Name = "pizza",
                            Price = 150.0,
                            Quantity = 120
                        });
                });

            modelBuilder.Entity("Restaurant_Project.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AccessDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("DeliverState")
                        .HasColumnType("bit");

                    b.Property<int>("DeliveryEmployer")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfItems")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("TableId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TableId");

                    b.ToTable("orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessDate = new DateTime(2024, 5, 8, 19, 53, 29, 846, DateTimeKind.Local).AddTicks(4858),
                            DeliverState = true,
                            DeliveryEmployer = 1,
                            NumberOfItems = 2,
                            OrderDate = new DateTime(2024, 5, 8, 19, 23, 29, 846, DateTimeKind.Local).AddTicks(4810),
                            Price = 500.0,
                            TableId = 6,
                            Type = "VIP"
                        },
                        new
                        {
                            Id = 2,
                            AccessDate = new DateTime(2024, 5, 8, 20, 53, 29, 846, DateTimeKind.Local).AddTicks(4865),
                            DeliverState = false,
                            DeliveryEmployer = 2,
                            NumberOfItems = 4,
                            OrderDate = new DateTime(2024, 5, 8, 19, 53, 29, 846, DateTimeKind.Local).AddTicks(4864),
                            Price = 200.0,
                            TableId = 3,
                            Type = "ordinary"
                        },
                        new
                        {
                            Id = 3,
                            AccessDate = new DateTime(2024, 5, 8, 20, 38, 29, 846, DateTimeKind.Local).AddTicks(4868),
                            DeliverState = false,
                            DeliveryEmployer = 2,
                            NumberOfItems = 3,
                            OrderDate = new DateTime(2024, 5, 8, 19, 53, 29, 846, DateTimeKind.Local).AddTicks(4867),
                            Price = 350.0,
                            TableId = 2,
                            Type = "ordinary"
                        },
                        new
                        {
                            Id = 4,
                            AccessDate = new DateTime(2024, 5, 8, 20, 23, 29, 846, DateTimeKind.Local).AddTicks(4871),
                            DeliverState = false,
                            DeliveryEmployer = 1,
                            NumberOfItems = 2,
                            OrderDate = new DateTime(2024, 5, 8, 19, 53, 29, 846, DateTimeKind.Local).AddTicks(4870),
                            Price = 400.0,
                            TableId = 6,
                            Type = "VIP"
                        });
                });

            modelBuilder.Entity("Restaurant_Project.Models.Table", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Floor")
                        .HasColumnType("int");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<bool>("State")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("tables");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Floor = 1,
                            Number = 1,
                            State = false
                        },
                        new
                        {
                            Id = 2,
                            Floor = 1,
                            Number = 2,
                            State = true
                        },
                        new
                        {
                            Id = 3,
                            Floor = 1,
                            Number = 3,
                            State = true
                        },
                        new
                        {
                            Id = 4,
                            Floor = 2,
                            Number = 1,
                            State = false
                        },
                        new
                        {
                            Id = 5,
                            Floor = 2,
                            Number = 2,
                            State = false
                        },
                        new
                        {
                            Id = 6,
                            Floor = 2,
                            Number = 3,
                            State = true
                        });
                });

            modelBuilder.Entity("FoodrinkOrder", b =>
                {
                    b.HasOne("Restaurant_Project.Models.Foodrink", null)
                        .WithMany()
                        .HasForeignKey("foodrinksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Restaurant_Project.Models.Order", null)
                        .WithMany()
                        .HasForeignKey("ordersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Restaurant_Project.Models.Foodrink", b =>
                {
                    b.HasOne("Restaurant_Project.Models.Category", "category")
                        .WithMany("foodrinks")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("category");
                });

            modelBuilder.Entity("Restaurant_Project.Models.Order", b =>
                {
                    b.HasOne("Restaurant_Project.Models.Table", "table")
                        .WithMany("orders")
                        .HasForeignKey("TableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("table");
                });

            modelBuilder.Entity("Restaurant_Project.Models.Category", b =>
                {
                    b.Navigation("foodrinks");
                });

            modelBuilder.Entity("Restaurant_Project.Models.Table", b =>
                {
                    b.Navigation("orders");
                });
#pragma warning restore 612, 618
        }
    }
}
