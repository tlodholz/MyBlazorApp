using System.ComponentModel.DataAnnotations;

namespace MyBlazorApp.Models
{
    public class Customer
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(100)] // Example: Maximum length of 100 characters
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)] // Example: Maximum length of 100 characters
        public string LastName { get; set; }

        [Required]
        [EmailAddress] // Ensures valid email format
        public string Email { get; set; }

        [Required]
        [Phone] // Ensures valid phone number format
        public string Phone { get; set; }

    }
}
