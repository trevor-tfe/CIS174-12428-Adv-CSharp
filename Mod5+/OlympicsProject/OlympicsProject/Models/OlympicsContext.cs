using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace CIS174TrevorStewart.Models
{
    public class OlympicsContext : DbContext
    {
        public OlympicsContext(DbContextOptions<OlympicsContext> options)
            : base(options)
        { }
        public DbSet<Country> Countries { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Sport>().HasData(
                new
                {
                    SportName = "Curling", 
                    Category = "Winter Olympics", 
                    Type = "Indoor"
                }, 
                new
                {
                    SportName = "Bobsleigh",
                    Category = "Winter Olympics",
                    Type = "Outdoor"
                },
                new
                {
                    SportName = "Diving",
                    Category = "Summer Olympics",
                    Type = "Indoor"
                }, 
                new
                {
                    SportName = "Road Cycling",
                    Category = "Summer Olympics",
                    Type = "Outdoor"
                },
                new
                {
                    SportName = "Archery",
                    Category = "Paralympics",
                    Type = "Indoor"
                },
                new
                {
                    SportName = "Canoe Sprint",
                    Category = "Paralympics",
                    Type = "Outdoor"
                },
                new
                {
                    SportName = "Breakdancing",
                    Category = "Youth Olympic Games",
                    Type = "Indoor"
                },
                new
                {
                    SportName = "Skateboarding",
                    Category = "Youth Olympic Games",
                    Type = "Outdoor"
                }
                );

            modelBuilder.Entity<Country>().HasData(
                new
                {
                    CountryId = 1,
                    Name = "Canada",
                    Flag = "Images/canada.jpg",
                    SportName = "Curling"
                },
                new
                {
                    CountryId = 2,
                    Name = "Sweden",
                    Flag = "Images/sweden.jpg",
                    SportName = "Curling"
                },
                new
                {
                    CountryId = 3,
                    Name = "Great Britain",
                    Flag = "Images/great_britain.jpg",
                    SportName = "Curling"
                },
                new
                {
                    CountryId = 4,
                    Name = "Jamaica",
                    Flag = "Images/jamaica.jpg",
                    SportName = "Bobsleigh"
                },
                new
                {
                    CountryId = 5,
                    Name = "Italy",
                    Flag = "Images/italy.jpg",
                    SportName = "Bobsleigh"
                },
                new
                {
                    CountryId = 6,
                    Name = "Japan",
                    Flag = "Images/japan.jpg",
                    SportName = "Bobsleigh"
                },
                new
                {
                    CountryId = 7,
                    Name = "Germany",
                    Flag = "Images/germany.jpg",
                    SportName = "Diving"
                },
                new
                {
                    CountryId = 8,
                    Name = "China",
                    Flag = "Images/china.jpg",
                    SportName = "Diving"
                },
                new
                {
                    CountryId = 9,
                    Name = "Mexico",
                    Flag = "Images/mexico.jpg",
                    SportName = "Diving"
                },
                new
                {
                    CountryId = 10,
                    Name = "Brazil",
                    Flag = "Images/brazil.jpg",
                    SportName = "Road Cycling"
                },
                new
                {
                    CountryId = 11,
                    Name = "Netherlands",
                    Flag = "Images/netherlands.jpg",
                    SportName = "Road Cycling"
                },
                new
                {
                    CountryId = 12,
                    Name = "USA",
                    Flag = "Images/united_states.jpg",
                    SportName = "Road Cycling"
                },
                new
                {
                    CountryId = 13,
                    Name = "Thailand",
                    Flag = "Images/thailand.jpg",
                    SportName = "Archery"
                },
                new
                {
                    CountryId = 14,
                    Name = "Uruguay",
                    Flag = "Images/uruguay.jpg",
                    SportName = "Archery"
                },
                new
                {
                    CountryId = 15,
                    Name = "Ukraine",
                    Flag = "Images/ukraine.jpg",
                    SportName = "Archery"
                },
                new
                {
                    CountryId = 16,
                    Name = "Austria",
                    Flag = "Images/austria.jpg",
                    SportName = "Canoe Sprint"
                },
                new
                {
                CountryId = 17,
                    Name = "Pakistan",
                    Flag = "Images/pakistan.jpg",
                    SportName = "Canoe Sprint"
                },
                new
                {
                    CountryId = 18,
                    Name = "Zimbabwe",
                    Flag = "Images/zimbabwe.jpg",
                    SportName = "Canoe Sprint"
                },
                new
                {
                    CountryId = 19,
                    Name = "France",
                    Flag = "Images/france.jpg",
                    SportName = "Breakdancing"
                },
                new
                {
                    CountryId = 20,
                    Name = "Cyprus",
                    Flag = "Images/cyprus.jpg",
                    SportName = "Breakdancing"
                },
                new
                {
                    CountryId = 21,
                    Name = "Russia",
                    Flag = "Images/russia.jpg",
                    SportName = "Breakdancing"
                },
                new
                {
                    CountryId = 22,
                    Name = "Finland",
                    Flag = "Images/finland.jpg",
                    SportName = "Skateboarding"
                },
                new
                {
                    CountryId = 23,
                    Name = "Slovakia",
                    Flag = "Images/slovakia.jpg",
                    SportName = "Skateboarding"
                },
                new
                {
                    CountryId = 24,
                    Name = "Portugal",
                    Flag = "Images/portugal.jpg",
                    SportName = "Skateboarding"
                });
        }
    }
}
