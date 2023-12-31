﻿// <auto-generated />
using CIS174TrevorStewart.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace OlympicsProject.Migrations
{
    [DbContext(typeof(OlympicsContext))]
    [Migration("20231021014846_oType")]
    partial class oType
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CIS174TrevorStewart.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
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
                        });
                });

            modelBuilder.Entity("CIS174TrevorStewart.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CountryId"));

                    b.Property<string>("Flag")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SportName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CountryId");

                    b.HasIndex("SportName");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            CountryId = 1,
                            Flag = "Images/canada.jpg",
                            Name = "Canada",
                            SportName = "Curling"
                        },
                        new
                        {
                            CountryId = 2,
                            Flag = "Images/sweden.jpg",
                            Name = "Sweden",
                            SportName = "Curling"
                        },
                        new
                        {
                            CountryId = 3,
                            Flag = "Images/great_britain.jpg",
                            Name = "Great Britain",
                            SportName = "Curling"
                        },
                        new
                        {
                            CountryId = 4,
                            Flag = "Images/jamaica.jpg",
                            Name = "Jamaica",
                            SportName = "Bobsleigh"
                        },
                        new
                        {
                            CountryId = 5,
                            Flag = "Images/italy.jpg",
                            Name = "Italy",
                            SportName = "Bobsleigh"
                        },
                        new
                        {
                            CountryId = 6,
                            Flag = "Images/japan.jpg",
                            Name = "Japan",
                            SportName = "Bobsleigh"
                        },
                        new
                        {
                            CountryId = 7,
                            Flag = "Images/germany.jpg",
                            Name = "Germany",
                            SportName = "Diving"
                        },
                        new
                        {
                            CountryId = 8,
                            Flag = "Images/china.jpg",
                            Name = "China",
                            SportName = "Diving"
                        },
                        new
                        {
                            CountryId = 9,
                            Flag = "Images/mexico.jpg",
                            Name = "Mexico",
                            SportName = "Diving"
                        },
                        new
                        {
                            CountryId = 10,
                            Flag = "Images/brazil.jpg",
                            Name = "Brazil",
                            SportName = "Road Cycling"
                        },
                        new
                        {
                            CountryId = 11,
                            Flag = "Images/netherlands.jpg",
                            Name = "Netherlands",
                            SportName = "Road Cycling"
                        },
                        new
                        {
                            CountryId = 12,
                            Flag = "Images/united_states.jpg",
                            Name = "USA",
                            SportName = "Road Cycling"
                        },
                        new
                        {
                            CountryId = 13,
                            Flag = "Images/thailand.jpg",
                            Name = "Thailand",
                            SportName = "Archery"
                        },
                        new
                        {
                            CountryId = 14,
                            Flag = "Images/uruguay.jpg",
                            Name = "Uruguay",
                            SportName = "Archery"
                        },
                        new
                        {
                            CountryId = 15,
                            Flag = "Images/ukraine.jpg",
                            Name = "Ukraine",
                            SportName = "Archery"
                        },
                        new
                        {
                            CountryId = 16,
                            Flag = "Images/austria.jpg",
                            Name = "Austria",
                            SportName = "Canoe Sprint"
                        },
                        new
                        {
                            CountryId = 17,
                            Flag = "Images/pakistan.jpg",
                            Name = "Pakistan",
                            SportName = "Canoe Sprint"
                        },
                        new
                        {
                            CountryId = 18,
                            Flag = "Images/zimbabwe.jpg",
                            Name = "Zimbabwe",
                            SportName = "Canoe Sprint"
                        },
                        new
                        {
                            CountryId = 19,
                            Flag = "Images/france.jpg",
                            Name = "France",
                            SportName = "Breakdancing"
                        },
                        new
                        {
                            CountryId = 20,
                            Flag = "Images/cyprus.jpg",
                            Name = "Cyprus",
                            SportName = "Breakdancing"
                        },
                        new
                        {
                            CountryId = 21,
                            Flag = "Images/russia.jpg",
                            Name = "Russia",
                            SportName = "Breakdancing"
                        },
                        new
                        {
                            CountryId = 22,
                            Flag = "Images/finland.jpg",
                            Name = "Finland",
                            SportName = "Skateboarding"
                        },
                        new
                        {
                            CountryId = 23,
                            Flag = "Images/slovakia.jpg",
                            Name = "Slovakia",
                            SportName = "Skateboarding"
                        },
                        new
                        {
                            CountryId = 24,
                            Flag = "Images/portugal.jpg",
                            Name = "Portugal",
                            SportName = "Skateboarding"
                        });
                });

            modelBuilder.Entity("CIS174TrevorStewart.Models.Sport", b =>
                {
                    b.Property<string>("SportName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("SportName");

                    b.HasIndex("CategoryId");

                    b.HasIndex("TypeId");

                    b.ToTable("Sports");

                    b.HasData(
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
                        });
                });

            modelBuilder.Entity("CIS174TrevorStewart.Models.oType", b =>
                {
                    b.Property<int>("TypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TypeId"));

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TypeId");

                    b.ToTable("Types");

                    b.HasData(
                        new
                        {
                            TypeId = 1,
                            TypeName = "Indoor"
                        },
                        new
                        {
                            TypeId = 2,
                            TypeName = "Outdoor"
                        });
                });

            modelBuilder.Entity("CIS174TrevorStewart.Models.Country", b =>
                {
                    b.HasOne("CIS174TrevorStewart.Models.Sport", "Sport")
                        .WithMany()
                        .HasForeignKey("SportName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sport");
                });

            modelBuilder.Entity("CIS174TrevorStewart.Models.Sport", b =>
                {
                    b.HasOne("CIS174TrevorStewart.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CIS174TrevorStewart.Models.oType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Type");
                });
#pragma warning restore 612, 618
        }
    }
}
