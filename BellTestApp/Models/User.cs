using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BellTestApp.Models
{
    public class User
    {
        public int ID { get; set; }
        
        [Display(Name = "First Name")]
        [StringLength(20, MinimumLength = 1)]
        [Required]
        public string FirstName { get; set; } = string.Empty;

        [Display(Name = "Last Name")]
        [StringLength(40, MinimumLength = 1)]
        [Required]
        public string LastName { get; set; } = string.Empty;

        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; } = string.Empty;

        [DataType(DataType.PhoneNumber)]
        public string? Phone { get; set; } = string.Empty;

        [StringLength(250)]
        public string? Address { get; set; } = string.Empty;

        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
    }
}
