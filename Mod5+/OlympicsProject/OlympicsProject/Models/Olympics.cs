using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace CIS174TrevorStewart.Models
{
    public class Category
    {
        public Category() { }
        public Category(int id) { CategoryId  = id; }
        public Category(string n) { CategoryName = n; }
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
    }
    public class oType
    {
        public oType() { }
        public oType(string n) { TypeName = n; }
        public oType(int i) { TypeId = i; }
        public string TypeName { get; set; } = string.Empty;
        [Key]
        public int TypeId { get; set; }
    }
    public class Sport
    {
        public Sport() { }

        [Required]
        [Key]
        public string SportName { get; set; } = string.Empty;

        [Required]
        public Category Category { get; set; } = null!;
        public oType Type { get; set; } = null!;
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
    public class OlympicViewModel
    {
        public OlympicViewModel() { }
        public string ActiveCategory { get; set; } = "all";
        public string ActiveType { get; set; } = "all";
        public List<Country> Countries { get; set; } = new List<Country>();
        public List<Sport> Sports { get; set; } = new List<Sport>();
        public List<Category> Categories { get; set; } = new List<Category>();
        public List<oType> Types { get; set; } = new List<oType>();
        public string CheckActiveCategory(string c) => 
            c.ToLower() == ActiveCategory.ToLower() ? "active" : "";

        public string CheckActiveType(string t) =>
            t.ToLower() == ActiveType.ToLower() ? "active" : "";
    }
}
