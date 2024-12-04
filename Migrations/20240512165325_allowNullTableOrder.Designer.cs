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
    [Migration("20240512165325_allowNullTableOrder")]
    partial class allowNullTableOrder
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Restaurant_Project.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

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
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("Phone")
                        .IsUnique();

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
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("Name")
                        .IsUnique();

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
                            AccessDate = new DateTime(2024, 5, 12, 19, 53, 25, 313, DateTimeKind.Local).AddTicks(9515),
                            DeliverState = true,
                            DeliveryEmployer = 1,
                            NumberOfItems = 2,
                            OrderDate = new DateTime(2024, 5, 12, 19, 23, 25, 313, DateTimeKind.Local).AddTicks(9448),
                            Price = 500.0,
                            TableId = 6,
                            Type = "VIP"
                        },
                        new
                        {
                            Id = 2,
                            AccessDate = new DateTime(2024, 5, 12, 20, 53, 25, 313, DateTimeKind.Local).AddTicks(9523),
                            DeliverState = false,
                            DeliveryEmployer = 2,
                            NumberOfItems = 4,
                            OrderDate = new DateTime(2024, 5, 12, 19, 53, 25, 313, DateTimeKind.Local).AddTicks(9521),
                            Price = 200.0,
                            TableId = 3,
                            Type = "ordinary"
                        },
                        new
                        {
                            Id = 3,
                            AccessDate = new DateTime(2024, 5, 12, 20, 38, 25, 313, DateTimeKind.Local).AddTicks(9528),
                            DeliverState = false,
                            DeliveryEmployer = 2,
                            NumberOfItems = 3,
                            OrderDate = new DateTime(2024, 5, 12, 19, 53, 25, 313, DateTimeKind.Local).AddTicks(9526),
                            Price = 350.0,
                            TableId = 2,
                            Type = "ordinary"
                        },
                        new
                        {
                            Id = 4,
                            AccessDate = new DateTime(2024, 5, 12, 20, 23, 25, 313, DateTimeKind.Local).AddTicks(9532),
                            DeliverState = false,
                            DeliveryEmployer = 1,
                            NumberOfItems = 2,
                            OrderDate = new DateTime(2024, 5, 12, 19, 53, 25, 313, DateTimeKind.Local).AddTicks(9531),
                            Price = 400.0,
                            TableId = 6,
                            Type = "VIP"
                        },
                        new
                        {
                            Id = 8,
                            AccessDate = new DateTime(2024, 5, 12, 20, 23, 25, 313, DateTimeKind.Local).AddTicks(9536),
                            DeliverState = false,
                            DeliveryEmployer = 1,
                            NumberOfItems = 4,
                            OrderDate = new DateTime(2024, 5, 12, 19, 53, 25, 313, DateTimeKind.Local).AddTicks(9535),
                            Price = 400.0,
                            TableId = 6,
                            Type = "VIP"
                        });
                });

            modelBuilder.Entity("Restaurant_Project.Models.Orders_Foodrinks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FoodrinkId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FoodrinkId");

                    b.HasIndex("OrderId");

                    b.ToTable("orders_foodrinks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FoodrinkId = 2,
                            OrderId = 1
                        },
                        new
                        {
                            Id = 2,
                            FoodrinkId = 2,
                            OrderId = 1
                        },
                        new
                        {
                            Id = 3,
                            FoodrinkId = 3,
                            OrderId = 2
                        },
                        new
                        {
                            Id = 4,
                            FoodrinkId = 3,
                            OrderId = 2
                        },
                        new
                        {
                            Id = 5,
                            FoodrinkId = 3,
                            OrderId = 2
                        },
                        new
                        {
                            Id = 6,
                            FoodrinkId = 3,
                            OrderId = 2
                        },
                        new
                        {
                            Id = 7,
                            FoodrinkId = 5,
                            OrderId = 3
                        },
                        new
                        {
                            Id = 8,
                            FoodrinkId = 5,
                            OrderId = 3
                        },
                        new
                        {
                            Id = 9,
                            FoodrinkId = 5,
                            OrderId = 3
                        },
                        new
                        {
                            Id = 10,
                            FoodrinkId = 1,
                            OrderId = 4
                        },
                        new
                        {
                            Id = 11,
                            FoodrinkId = 1,
                            OrderId = 4
                        },
                        new
                        {
                            Id = 12,
                            FoodrinkId = 1,
                            OrderId = 8
                        },
                        new
                        {
                            Id = 13,
                            FoodrinkId = 1,
                            OrderId = 8
                        },
                        new
                        {
                            Id = 14,
                            FoodrinkId = 2,
                            OrderId = 8
                        },
                        new
                        {
                            Id = 15,
                            FoodrinkId = 2,
                            OrderId = 8
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

                    b.HasIndex("Number", "Floor")
                        .IsUnique();

                    b.ToTable("tables");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Floor = 1,
                            Number = 1,
                            State = true
                        },
                        new
                        {
                            Id = 2,
                            Floor = 1,
                            Number = 2,
                            State = false
                        },
                        new
                        {
                            Id = 3,
                            Floor = 1,
                            Number = 3,
                            State = false
                        },
                        new
                        {
                            Id = 4,
                            Floor = 2,
                            Number = 1,
                            State = true
                        },
                        new
                        {
                            Id = 5,
                            Floor = 2,
                            Number = 2,
                            State = true
                        },
                        new
                        {
                            Id = 6,
                            Floor = 2,
                            Number = 3,
                            State = false
                        });
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

            modelBuilder.Entity("Restaurant_Project.Models.Orders_Foodrinks", b =>
                {
                    b.HasOne("Restaurant_Project.Models.Foodrink", "foodrink")
                        .WithMany("orders_foodrinks")
                        .HasForeignKey("FoodrinkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Restaurant_Project.Models.Order", "order")
                        .WithMany("orders_foodrinks")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("foodrink");

                    b.Navigation("order");
                });

            modelBuilder.Entity("Restaurant_Project.Models.Category", b =>
                {
                    b.Navigation("foodrinks");
                });

            modelBuilder.Entity("Restaurant_Project.Models.Foodrink", b =>
                {
                    b.Navigation("orders_foodrinks");
                });

            modelBuilder.Entity("Restaurant_Project.Models.Order", b =>
                {
                    b.Navigation("orders_foodrinks");
                });

            modelBuilder.Entity("Restaurant_Project.Models.Table", b =>
                {
                    b.Navigation("orders");
                });
#pragma warning restore 612, 618
        }
    }
}
