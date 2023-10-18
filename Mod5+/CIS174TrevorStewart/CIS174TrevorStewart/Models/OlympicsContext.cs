using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace CIS174TrevorStewart.Models
{
    public class OlympicsContext : DbContext
    {
        public OlympicsContext(DbContextOptions<StudentContext> options)
            : base(options)
        { }

        public DbSet<Sport> Sports { get; set; } = null!;
        public DbSet<Country> Countries { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Sport>().HasData(
                new Sport 
                {
                    Name = "Curling",
                    Category = "Winter Olympics",
                    Type = "Indoor"
                },
                new Sport
                {
                    Name = "Bobsleigh",
                    Category = "Winter Olympics",
                    Type = "Outdoor"
                },
                new Sport
                {
                    Name = "Diving",
                    Category = "Summer Olympics",
                    Type = "Indoor"
                },
                new Sport
                {
                    Name = "Road Cycling",
                    Category = "Summer Olympics",
                    Type = "Outdoor"
                },
                new Sport
                {
                    Name = "Archery",
                    Category = "Paralympics",
                    Type = "Indoor"
                },
                new Sport
                {
                    Name = "Canoe Sprint",
                    Category = "Paralympics",
                    Type = "Outdoor"
                },
                new Sport
                {
                    Name = "Breakdancing",
                    Category = "Youth Olympic Games",
                    Type = "Indoor"
                },
                new Sport
                {
                    Name = "Skateboarding",
                    Category = "Youth Olympic Games",
                    Type = "Outdoor"
                });

            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Name = "Canada",
                    Flag = "Images/canada.jpg",
                    SportName = "Curling"
                },
                new Country
                {
                    Name = "Sweden",
                    Flag = "Images/sweden.jpg",
                    SportName = "Curling"
                },
                new Country
                {
                    Name = "Great Britain",
                    Flag = "Images/great_britain.jpg",
                    SportName = "Curling"
                },
                new Country
                {
                    Name = "Jamaica",
                    Flag = "Images/jamaica.jpg",
                    SportName = "Bobsleigh"
                },
                new Country
                {
                    Name = "Italy",
                    Flag = "Images/italy.jpg",
                    SportName = "Bobsleigh"
                },
                new Country
                {
                    Name = "Japan",
                    Flag = "Images/japan.jpg",
                    SportName = "Bobsleigh"
                },
                new Country
                {
                    Name = "Germany",
                    Flag = "Images/germany.jpg",
                    SportName = "Diving"
                },
                new Country
                {
                    Name = "China",
                    Flag = "Images/china.jpg",
                    SportName = "Diving"
                },
                new Country
                {
                    Name = "Mexico",
                    Flag = "Images/mexico.jpg",
                    SportName = "Diving"
                },
                new Country
                {
                    Name = "Brazil",
                    Flag = "Images/brazil.jpg",
                    SportName = "Road Cycling"
                },
                new Country
                {
                    Name = "Netherlands",
                    Flag = "Images/netherlands.jpg",
                    SportName = "Road Cycling"
                },
                new Country
                {
                    Name = "USA",
                    Flag = "Images/united_states.jpg",
                    SportName = "Road Cycling"
                },
                new Country
                {
                    Name = "Thailand",
                    Flag = "Images/thailand.jpg",
                    SportName = "Archery"
                },
                new Country
                {
                    Name = "Uruguay",
                    Flag = "Images/uruguay.jpg",
                    SportName = "Archery"
                },
                new Country
                {
                    Name = "Ukraine",
                    Flag = "Images/ukraine.jpg",
                    SportName = "Archery"
                },
                new Country
                {
                    Name = "Austria",
                    Flag = "Images/austria.jpg",
                    SportName = "Canoe Sprint"
                },
                new Country
                {
                    Name = "Zimbabwe",
                    Flag = "Images/zimbabwe.jpg",
                    SportName = "Canoe Sprint"
                },
                new Country
                {
                    Name = "France",
                    Flag = "Images/france.jpg",
                    SportName = "Breakdancing"
                },
                new Country
                {
                    Name = "Cyprus",
                    Flag = "Images/cyprus.jpg",
                    SportName = "Breakdancing"
                },
                new Country
                {
                    Name = "Russia",
                    Flag = "Images/russia.jpg",
                    SportName = "Breakdancing"
                },
                new Country
                {
                    Name = "Finland",
                    Flag = "Images/finland.jpg",
                    SportName = "Skateboarding"
                },
                new Country
                {
                    Name = "Slovakia",
                    Flag = "Images/slovakia.jpg",
                    SportName = "Skateboarding"
                },
                new Country
                {
                    Name = "Portugal",
                    Flag = "Images/portugal.jpg",
                    SportName = "Skateboarding"
                }
                );
        }
    }
}
