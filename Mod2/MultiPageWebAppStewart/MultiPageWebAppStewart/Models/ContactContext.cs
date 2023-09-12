using Microsoft.EntityFrameworkCore;

namespace MultiPageWebAppStewart.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options)
            : base(options)
        { }

        public DbSet<Contact> Contacts { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Contact>().HasData(
                new Contact { Name = "Trevor Steart", ContactId = 1, Phone = 15154025466, Address = "2637 Kinsey Ave.", Note = "C# Student" },
                new Contact { Name = "Amber Lang", ContactId = 2, Phone = 15154025466, Address = "1234 Nunya Bidniss Ln.", Note = "Cousin" },
                new Contact { Name = "Amy Cole", ContactId = 3, Phone = 15154025466, Address = "2345 Wrogn Direksun Blvd.", Note = "Cousin" }
            );
        }
    }
}
