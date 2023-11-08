using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using CIS174TrevorStewart.Models;

namespace CIS174TrevorStewart.Models
{
    public class OlympicsContext : DbContext
    {
        public OlympicsContext(DbContextOptions<OlympicsContext> options)
            : base(options)
        { }
        public DbSet<oType> Types { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Sport> Sports { get; set; } = null!;
        public DbSet<Country> Countries { get; set; } = null!;

        //TODO SECTION
        public DbSet<ToDoCategory> ToDoCategories { get; set; } = null!;
        public DbSet<ToDoStatus> ToDoStatuses { get; set; } = null!;
        public DbSet<ToDo> ToDos { get; set; } = null!;

        //TICKET SECTION
        public DbSet<Ticket> Tickets { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //TICKET SECTION
            modelBuilder.Entity<Ticket>().HasData(
                new Ticket { 
                    TicketID = 1,
                    TicketName = "Homework",
                    Description = "Finish Homework",
                    SprintNumber = 1,
                    PointValue = 1,
                    Status = "Quality Assurance"
                });

            //TODO SECTION
            modelBuilder.Entity<ToDoCategory>().HasData(
                new ToDoCategory { CategoryId = "work", CategoryName = "Work" },
                new ToDoCategory { CategoryId = "home", CategoryName = "Home" },
                new ToDoCategory { CategoryId = "ex", CategoryName = "Exercise" },
                new ToDoCategory { CategoryId = "shop", CategoryName = "Shopping" },
                new ToDoCategory { CategoryId = "call", CategoryName = "Contact" }
                );

            modelBuilder.Entity<ToDoStatus>().HasData(
                new ToDoStatus { StatusId = "open", StatusName = "Open" },
                new ToDoStatus { StatusId = "closed", StatusName = "Completed" }
                );

            //OLYMPIC SECTION
            modelBuilder.Entity<Category>().HasData(
                new
                {
                    CategoryId = 1,
                    CategoryName = "Winter Olympics"
                },
                new
                {
                    CategoryId = 2,
                    CategoryName = "Summer Olympics"
                },
                new
                {
                    CategoryId = 3,
                    CategoryName = "Paralympics"
                },
                new
                {
                    CategoryId = 4,
                    CategoryName = "Youth Olympic Games"
                }
                );

            modelBuilder.Entity<oType>().HasData(
                new
                {
                    TypeId = 1,
                    TypeName = "Indoor"
                },
                new
                {
                    TypeId = 2,
                    TypeName = "Outdoor"
                }
                );

            modelBuilder.Entity<Sport>().HasData(
                new
                {
                    SportName = "Curling", 
                    CategoryId = 1, 
                    TypeId = 1
                }, 
                new
                {
                    SportName = "Bobsleigh",
                    CategoryId = 1,
                    TypeId = 2
                },
                new
                {
                    SportName = "Diving",
                    CategoryId = 2,
                    TypeId = 1
                }, 
                new
                {
                    SportName = "Road Cycling",
                    CategoryId = 2,
                    TypeId = 2
                },
                new
                {
                    SportName = "Archery",
                    CategoryId = 3,
                    TypeId = 1
                },
                new
                {
                    SportName = "Canoe Sprint",
                    CategoryId = 3,
                    TypeId = 2
                },
                new
                {
                    SportName = "Breakdancing",
                    CategoryId = 4,
                    TypeId = 1
                },
                new
                {
                    SportName = "Skateboarding",
                    CategoryId = 4,
                    TypeId = 2
                }
                );

            modelBuilder.Entity<Country>().HasData(
                new
                {
                    CountryId = 1,
                    Name = "Canada",
                    Flag = "canada.jpg",
                    SportName = "Curling"
                },
                new
                {
                    CountryId = 2,
                    Name = "Sweden",
                    Flag = "sweden.jpg",
                    SportName = "Curling"
                },
                new
                {
                    CountryId = 3,
                    Name = "Great Britain",
                    Flag = "great_britain.jpg",
                    SportName = "Curling"
                },
                new
                {
                    CountryId = 4,
                    Name = "Jamaica",
                    Flag = "jamaica.jpg",
                    SportName = "Bobsleigh"
                },
                new
                {
                    CountryId = 5,
                    Name = "Italy",
                    Flag = "italy.jpg",
                    SportName = "Bobsleigh"
                },
                new
                {
                    CountryId = 6,
                    Name = "Japan",
                    Flag = "japan.jpg",
                    SportName = "Bobsleigh"
                },
                new
                {
                    CountryId = 7,
                    Name = "Germany",
                    Flag = "germany.jpg",
                    SportName = "Diving"
                },
                new
                {
                    CountryId = 8,
                    Name = "China",
                    Flag = "china.jpg",
                    SportName = "Diving"
                },
                new
                {
                    CountryId = 9,
                    Name = "Mexico",
                    Flag = "mexico.jpg",
                    SportName = "Diving"
                },
                new
                {
                    CountryId = 10,
                    Name = "Brazil",
                    Flag = "brazil.jpg",
                    SportName = "Road Cycling"
                },
                new
                {
                    CountryId = 11,
                    Name = "Netherlands",
                    Flag = "netherlands.jpg",
                    SportName = "Road Cycling"
                },
                new
                {
                    CountryId = 12,
                    Name = "USA",
                    Flag = "united_states.jpg",
                    SportName = "Road Cycling"
                },
                new
                {
                    CountryId = 13,
                    Name = "Thailand",
                    Flag = "thailand.jpg",
                    SportName = "Archery"
                },
                new
                {
                    CountryId = 14,
                    Name = "Uruguay",
                    Flag = "uruguay.jpg",
                    SportName = "Archery"
                },
                new
                {
                    CountryId = 15,
                    Name = "Ukraine",
                    Flag = "ukraine.jpg",
                    SportName = "Archery"
                },
                new
                {
                    CountryId = 16,
                    Name = "Austria",
                    Flag = "austria.jpg",
                    SportName = "Canoe Sprint"
                },
                new
                {
                CountryId = 17,
                    Name = "Pakistan",
                    Flag = "pakistan.jpg",
                    SportName = "Canoe Sprint"
                },
                new
                {
                    CountryId = 18,
                    Name = "Zimbabwe",
                    Flag = "zimbabwe.jpg",
                    SportName = "Canoe Sprint"
                },
                new
                {
                    CountryId = 19,
                    Name = "France",
                    Flag = "france.jpg",
                    SportName = "Breakdancing"
                },
                new
                {
                    CountryId = 20,
                    Name = "Cyprus",
                    Flag = "cyprus.jpg",
                    SportName = "Breakdancing"
                },
                new
                {
                    CountryId = 21,
                    Name = "Russia",
                    Flag = "russia.jpg",
                    SportName = "Breakdancing"
                },
                new
                {
                    CountryId = 22,
                    Name = "Finland",
                    Flag = "finland.jpg",
                    SportName = "Skateboarding"
                },
                new
                {
                    CountryId = 23,
                    Name = "Slovakia",
                    Flag = "slovakia.jpg",
                    SportName = "Skateboarding"
                },
                new
                {
                    CountryId = 24,
                    Name = "Portugal",
                    Flag = "portugal.jpg",
                    SportName = "Skateboarding"
                }
            );
        }
    }
}
