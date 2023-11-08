using System.ComponentModel.DataAnnotations;
using CIS174TrevorStewart.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace CIS174TrevorStewart.Models
{
    public class Ticket
    {
        public Ticket() {
            ValidStatus.Add("To Do");
            ValidStatus.Add("In Progress");
            ValidStatus.Add("Quality Assurance");
            ValidStatus.Add("Done");
        }

        [Key]
        [Required]
        public int TicketID { get; set; }

        [Required]
        public string TicketName { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        public int SprintNumber { get; set; }

        [Required]
        public int PointValue { get; set; }

        [Required]
        public string Status { get; set; } = string.Empty;

        [ValidateNever]
        public List<string> ValidStatus { get; } = new List<string>();
    }

    public class TicketFilters
    {
        public TicketFilters(string filterString)
        {
            FilterString = filterString ?? "all-all";
            string[] filters = FilterString.Split('-');
            PointValues = filters[0];
            Status = filters[1];
        }

        public string FilterString { get; set; } = string.Empty;
        public string PointValues { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;

        public bool HasPointValue => PointValues != "all";
        public bool HasStatus => Status != "all";

        public static Dictionary<string, string> StatusFilterValues =>
            new Dictionary<string, string>
            {
                {"to do", "To Do"},
                {"in progress", "In Progress"},
                {"quality assurance", "Quality Assurance"},
                {"done", "Done"}
            };
    }
}
