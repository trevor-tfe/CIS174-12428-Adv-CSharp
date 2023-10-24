using System.ComponentModel.DataAnnotations;
using CIS174TrevorStewart.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace CIS174TrevorStewart.Models
{
    public class ToDoCategory
    {
        public ToDoCategory() { }
        [Key]
        public string CategoryId { get; set; } = string.Empty;
        public string CategoryName { get; set; } = string.Empty;
    }

    public class ToDoStatus
    {
        public ToDoStatus() { }
        [Key]
        public string StatusId { get; set; } = string.Empty;
        public string StatusName { get; set; } = string.Empty;
    }

    public class ToDo
    {
        public ToDo() { }
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a description.")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a due date.")]
        public DateTime? DueDate { get; set; }

        [Required(ErrorMessage = "Please select a category.")]
        public string CategoryId { get; set; } = string.Empty;

        [ValidateNever]
        public ToDoCategory Category { get; set; } = null!;

        [Required(ErrorMessage = "Please select a status.")]
        public string StatusId { get; set; } = string.Empty;

        [ValidateNever]
        public ToDoStatus Status { get; set; } = null!;

        public bool Overdue => StatusId == "open" && DueDate < DateTime.Today;
    }
    public class Filters
    {
        public Filters(string filterString) 
        {
            FilterString = filterString ?? "all-all-all";
            string[] filters = FilterString.Split('-');
            CategoryId = filters[0];
            Due = filters[1];
            StatusId = filters[2];
        }
        public string FilterString { get; } = string.Empty;
        public string CategoryId { get; } = string.Empty;
        public string Due { get; } = string.Empty;
        public string StatusId { get; } = string.Empty;

        public bool HasCategory => CategoryId.ToLower() != "all";
        public bool HasDue => Due.ToLower() != "all";
        public bool HasStatus => StatusId.ToLower() != "all";

        public static Dictionary<string, string> DueFilterValues =>
            new Dictionary<string, string> {
                { "future", "Future"},
                { "past", "Past" },
                { "today", "Today" }
            };
        public bool IsPast => Due.ToLower() == "past";
        public bool IsFuture => Due.ToLower() == "future";
        public bool IsToday => Due.ToLower() == "today";
    }
}
