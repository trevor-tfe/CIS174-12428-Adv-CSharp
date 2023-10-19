using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace CIS174TrevorStewart.Models
{
    public class Sport
    {
        public Sport() { }
        public Sport(string n, string c, string t) { SportName = n; Category = c; Type = t; }

        [Required]
        [Key]
        public string SportName { get; set; } = string.Empty;

        [Required]
        public string Category { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
    }
    public class Country
    {
        [Key]
        public int CountryId { get; set; }
        public Country() { }
        public string Flag { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public Sport Sport { get; set; } = null!;
    }
}
