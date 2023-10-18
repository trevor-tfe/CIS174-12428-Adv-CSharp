using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace CIS174TrevorStewart.Models
{
    public class Sport
    {
        public string[] AllowedCategories = new string[] { "Summer Olympics", "Winter Olympics", "Paralympic Games", "Youth Olympic Games" };
        public Sport() { }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Category {
            get { return Category; }
            set {
                if (!AllowedCategories.Any(x => x == value))
                {
                    throw new ArgumentException("Not valid category");
                }
                Category = value;
            }
        }
        public string Type { get; set; }
    }
    public class Country
    {
        public Country() { }
        public string Flag { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string SportName { get; set; } = null!;
    }
}
