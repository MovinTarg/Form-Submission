using System.ComponentModel.DataAnnotations;

namespace form_submission.Models
{
    public class User : BaseEntity
    {
        [Required]
        [MinLength (4)]
        public string First_name { get; set; }
        [Required]
        [MinLength (4)]
        public string Last_name { get; set; }
        [Required]
        [Range (0, 150)]
        public int Age { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MinLength (8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}