using Microsoft.EntityFrameworkCore;
using Restaurant_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Project
{
    internal class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Connections.sqlConStr);
        }

        public DbSet<Employer> employers { get; set; }

        public DbSet<Order> orders { get; set; }
        public DbSet<Foodrink> foodrinks { get; set; }

        public DbSet<Orders_Foodrinks> orders_foodrinks { get; set;}

        public DbSet<Category> categories { get; set; }

        public DbSet<Table> tables { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Table>().HasIndex(d => new { d.Number, d.Floor }).IsUnique();
            modelBuilder.Entity<Foodrink>().HasIndex(d => new { d.Name }).IsUnique();
            modelBuilder.Entity<Category>().HasIndex(d => new { d.Name }).IsUnique();
            modelBuilder.Entity<Employer>().HasIndex(d => new { d.Name }).IsUnique();
            modelBuilder.Entity<Employer>().HasIndex(d => new { d.Phone }).IsUnique();






            modelBuilder.Entity<Employer>().Property(x => x.Age).IsRequired();
            //seed

            modelBuilder.Entity<Employer>().HasData(
                new Employer() { Id = 1, Name = "Ahmed Jalal", Phone = "0947675777", Address = "jesr al-abiad", Age = 22 },
                new Employer() { Id = 2, Name = "Emad Khayat", Phone = "0933431567", Address = "afif", Age = 23 },
                new Employer() { Id = 3, Name = "Bilal Tahan", Phone = "0968793347", Address = "midan", Age = 19 },
                new Employer() { Id = 4, Name = "Bahaa Nahas", Phone = "0928139925", Address = "shaghour", Age = 33 }
                );
            //we can make unique(number,floor)
            modelBuilder.Entity<Table>().HasData(
                new Table() { Id = 7, Number = 0, State = true, Floor = 0 },
                new Table() { Id = 1, Number = 01, State = true, Floor = 1 },
                new Table() { Id = 2, Number = 02, State = false, Floor = 1 },
                new Table() { Id = 3, Number = 03, State = false, Floor = 1 },
                new Table() { Id = 4, Number = 01, State = true, Floor = 2 },
                new Table() { Id = 5, Number = 02, State = true, Floor = 2 },
                new Table() { Id = 6, Number = 03, State = false, Floor = 2 }
                );
            //we can check if the table is busy so we can add order and check delevry state true after access date
            modelBuilder.Entity<Order>().HasData(
                new Order() { Id = 1, OrderDate = DateTime.Now.AddMinutes(-30), AccessDate = DateTime.Now, Type = "VIP", DeliverState = true, DeliveryEmployer = 1, Price = 500, NumberOfItems = 2, TableId = 6 },
                new Order() { Id = 2, OrderDate = DateTime.Now, AccessDate = DateTime.Now.AddMinutes(60), Type = "ordinary", DeliverState = false, DeliveryEmployer = 2, Price = 200, NumberOfItems = 4, TableId = 3 },
                new Order() { Id = 3, OrderDate = DateTime.Now, AccessDate = DateTime.Now.AddMinutes(45), Type = "ordinary", DeliverState = false, DeliveryEmployer = 2, Price = 350, NumberOfItems = 3, TableId = 2 },
                new Order() { Id = 4, OrderDate = DateTime.Now, AccessDate = DateTime.Now.AddMinutes(30), Type = "VIP", DeliverState = false, DeliveryEmployer = 1, Price = 400, NumberOfItems = 2, TableId = 6 },
    /**/        new Order() { Id = 8, OrderDate = DateTime.Now, AccessDate = DateTime.Now.AddMinutes(30), Type = "VIP", DeliverState = false, DeliveryEmployer = 1, Price = 400, NumberOfItems = 4, TableId = 6 }
            );
            modelBuilder.Entity<Category>().HasData(
                new Category() { Id = 1, Name = "cold drink" },
                new Category() { Id = 2, Name = "hot drink" },
                new Category() { Id = 3, Name = "main meal" },
                new Category() { Id = 4, Name = "desert" }
                );
            // we can add name of food and make name unique
            modelBuilder.Entity<Foodrink>().HasData(
                new Foodrink() { Id = 1, Name = "cheese cake", Price = 200, Quantity = 100, CategoryId = 4 },
                new Foodrink() { Id = 2, Name = "chicken", Price = 250, Quantity = 80, CategoryId = 3 },
                new Foodrink() { Id = 3, Name = "cola", Price = 50, Quantity = 400, CategoryId = 1 },
                new Foodrink() { Id = 4, Name = "coffee", Price = 70, Quantity = 500, CategoryId = 2 },
                new Foodrink() { Id = 5, Name = "pizza", Price = 150, Quantity = 120, CategoryId = 3 }
            );
            modelBuilder.Entity<Orders_Foodrinks>().HasData(
                new Orders_Foodrinks() { Id = 1, OrderId = 1, FoodrinkId = 2 },
                new Orders_Foodrinks() { Id = 2, OrderId = 1, FoodrinkId = 2 },
                new Orders_Foodrinks() { Id = 3, OrderId = 2, FoodrinkId = 3 },
                new Orders_Foodrinks() { Id = 4, OrderId = 2, FoodrinkId = 3 },
                new Orders_Foodrinks() { Id = 5, OrderId = 2, FoodrinkId = 3 },
                new Orders_Foodrinks() { Id = 6, OrderId = 2, FoodrinkId = 3 },
                new Orders_Foodrinks() { Id = 7, OrderId = 3, FoodrinkId = 5 },
                new Orders_Foodrinks() { Id = 8, OrderId = 3, FoodrinkId = 5 },
                new Orders_Foodrinks() { Id = 9, OrderId = 3, FoodrinkId = 5 },
                new Orders_Foodrinks() { Id = 10, OrderId = 4, FoodrinkId = 1 },
                new Orders_Foodrinks() { Id = 11, OrderId = 4, FoodrinkId = 1 },
   /**/         new Orders_Foodrinks() { Id = 12, OrderId = 8, FoodrinkId = 1 },
                new Orders_Foodrinks() { Id = 13, OrderId = 8, FoodrinkId = 1 },
                new Orders_Foodrinks() { Id = 14, OrderId = 8, FoodrinkId = 2 },
   /**/         new Orders_Foodrinks() { Id = 15, OrderId = 8, FoodrinkId = 2 }

            );








        }

    }



    
}
