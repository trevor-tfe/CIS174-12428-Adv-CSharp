using System.ComponentModel.DataAnnotations;

namespace MultiPageWebAppStewart.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "Please Enter a name")]
        public string? Name { get; set; }

        public int ContactId { get; set; }

        [Range(10000000000, 9999999999999, ErrorMessage = "Please enter phone number without spaces or '-'s. Include country code.")]
        public long Phone { get; set; }

        public string Address { get; set; } = string.Empty;

        public string Note { get; set; } = string.Empty;
    }
}
