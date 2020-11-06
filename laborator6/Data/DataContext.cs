using laborator6.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace laborator6.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ToDo> ToDos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDo>().HasData(
                new ToDo
                {
                    Id = 1,
                    Description = "Do .NET Homework!",
                    Created = new DateTime(2020, 11, 5),
                    IsDone = false
                },
                new ToDo
                {
                    Id = 2,
                    Description = "Do ML Homework!",
                    Created = new DateTime(2020, 11, 2),
                    IsDone = false
                },
                new ToDo
                {
                    Id = 3,
                    Description = "Do ISSA Homework!",
                    Created = new DateTime(2020, 10, 30),
                    IsDone = true
                },
                new ToDo
                {
                    Id = 4,
                    Description = "Do SI Homework!",
                    Created = new DateTime(2020, 10, 27),
                    IsDone = false
                },
                new ToDo
                {
                    Id = 5,
                    Description = "Do Python Homework!",
                    Created = new DateTime(2020, 11, 1),
                    IsDone = true
                }
            );
        }
    }
}
