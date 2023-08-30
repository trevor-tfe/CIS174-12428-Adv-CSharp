using System.ComponentModel.DataAnnotations;

namespace FirstResponsiveWebAppStewart.Models
{
    public class WebAppStewart
    {
        [Required(ErrorMessage = "Please enter your name.")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Please enter your birth year.")]
        [Range(1900, 2023, ErrorMessage = "Please enter an age between 1900 and 2023.")]
        public int? BirthYear { get; set; }
        public string? AgeThisYear() 
        {
            string? name = Name;
            int? year = BirthYear;
            int? currYear = 2023;
            int? age = currYear - year;
            string output = name + " will be " + age + " on December 31st";
            return output; 
        }
    }
}
