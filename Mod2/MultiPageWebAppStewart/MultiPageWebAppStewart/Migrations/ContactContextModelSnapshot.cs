﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MultiPageWebAppStewart.Models;

#nullable disable

namespace MultiPageWebAppStewart.Migrations
{
    [DbContext(typeof(ContactContext))]
    partial class ContactContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MultiPageWebAppStewart.Models.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContactId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Phone")
                        .HasColumnType("bigint");

                    b.HasKey("ContactId");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            ContactId = 1,
                            Address = "2637 Kinsey Ave.",
                            Name = "Trevor Steart",
                            Note = "C# Student",
                            Phone = 15154025466L
                        },
                        new
                        {
                            ContactId = 2,
                            Address = "1234 Nunya Bidniss Ln.",
                            Name = "Amber Lang",
                            Note = "Cousin",
                            Phone = 15154025466L
                        },
                        new
                        {
                            ContactId = 3,
                            Address = "2345 Wrogn Direksun Blvd.",
                            Name = "Amy Cole",
                            Note = "Cousin",
                            Phone = 15154025466L
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
