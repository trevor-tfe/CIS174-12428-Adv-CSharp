using System.ComponentModel.DataAnnotations;

namespace EFCoreWebAppStewart.Models
{
    public class Genre
    {
        public string GenreId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
    }
}
