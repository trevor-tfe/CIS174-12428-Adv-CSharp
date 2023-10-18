using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

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

            /*            modelBuilder.Entity<Sport>().HasData(
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
           */

            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Name = "Canada",
                    Flag = "Images/canada.jpg",
                    Sport = new Sport("Curling", "Winter Olympics", "Indoor")
                },
                new Country
                {
                    Name = "Sweden",
                    Flag = "Images/sweden.jpg",
                    Sport = new Sport("Curling", "Winter Olympics", "Indoor")
                },
                new Country
                {
                    Name = "Great Britain",
                    Flag = "Images/great_britain.jpg",
                    Sport = new Sport("Curling", "Winter Olympics", "Indoor")
                },
                new Country
                {
                    Name = "Jamaica",
                    Flag = "Images/jamaica.jpg",
                    Sport = new Sport("Bobsleigh", "Winter Olympics", "Outdoor")
                },
                new Country
                {
                    Name = "Italy",
                    Flag = "Images/italy.jpg",
                    Sport = new Sport("Bobsleigh", "Winter Olympics", "Outdoor")
                },
                new Country
                {
                    Name = "Japan",
                    Flag = "Images/japan.jpg",
                    Sport = new Sport("Bobsleigh", "Winter Olympics", "Outdoor")
                },
                new Country
                {
                    Name = "Germany",
                    Flag = "Images/germany.jpg",
                    Sport = new Sport("Diving", "Summer Olympics", "Indoor")
                },
                new Country
                {
                    Name = "China",
                    Flag = "Images/china.jpg",
                    Sport = new Sport("Diving", "Summer Olympics", "Indoor")
                },
                new Country
                {
                    Name = "Mexico",
                    Flag = "Images/mexico.jpg",
                    Sport = new Sport("Bobsleigh", "Winter Olympics", "Outdoor")
                },
                new Country
                {
                    Name = "Brazil",
                    Flag = "Images/brazil.jpg",
                    Sport = new Sport("Road Cycling", "Summer Olympics", "Outdoor")
                },
                new Country
                {
                    Name = "Netherlands",
                    Flag = "Images/netherlands.jpg",
                    Sport = new Sport("Road Cycling", "Summer Olympics", "Outdoor")
                },
                new Country
                {
                    Name = "USA",
                    Flag = "Images/united_states.jpg",
                    Sport = new Sport("Road Cycling", "Summer Olympics", "Outdoor")
                },
                new Country
                {
                    Name = "Thailand",
                    Flag = "Images/thailand.jpg",
                    Sport = new Sport("Archery", "Paralympics", "Indoor")
                },
                new Country
                {
                    Name = "Uruguay",
                    Flag = "Images/uruguay.jpg",
                    Sport = new Sport("Archery", "Paralympics", "Indoor")
                },
                new Country
                {
                    Name = "Ukraine",
                    Flag = "Images/ukraine.jpg",
                    Sport = new Sport("Archery", "Paralympics", "Indoor")
                },
                new Country
                {
                    Name = "Austria",
                    Flag = "Images/austria.jpg",
                    Sport = new Sport("Canoe Sprint", "Paralympics", "Outdoor")
                },
                new Country
                {
                    Name = "Zimbabwe",
                    Flag = "Images/zimbabwe.jpg",
                    Sport = new Sport("Canoe Sprint", "Paralympics", "Outdoor")
                },
                new Country
                {
                    Name = "France",
                    Flag = "Images/france.jpg",
                    Sport = new Sport("Canoe Sprint", "Paralympics", "Outdoor")
                },
                new Country
                {
                    Name = "Cyprus",
                    Flag = "Images/cyprus.jpg",
                    Sport = new Sport("Breakdancing", "Youth Olympic Games", "Indoor")
                },
                new Country
                {
                    Name = "Russia",
                    Flag = "Images/russia.jpg",
                    Sport = new Sport("Breakdancing", "Youth Olympic Games", "Indoor")
                },
                new Country
                {
                    Name = "Finland",
                    Flag = "Images/finland.jpg",
                    Sport = new Sport("Breakdancing", "Youth Olympic Games", "Indoor")
                },
                new Country
                {
                    Name = "Slovakia",
                    Flag = "Images/slovakia.jpg",
                    Sport = new Sport("Skateboarding", "Youth Olympic Games", "Outdoor")
                },
                new Country
                {
                    Name = "Portugal",
                    Flag = "Images/portugal.jpg",
                    Sport = new Sport("Skateboarding", "Youth Olympic Games", "Outdoor")
                }
                );
        }
    }
}
