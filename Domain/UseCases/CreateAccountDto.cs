using System.ComponentModel.DataAnnotations;

namespace Domain.UseCases
{
    public class CreateAccountDto
    {

        [Required(ErrorMessage = "Username is required.")]
        [MinLength(5, ErrorMessage = "Please enter a username with minimum 5 characters.")]

        public string Username { get; set; } = null!;

        [Required(ErrorMessage = "E-mail is required.")]
        [EmailAddress(ErrorMessage = "Please enter a valid e-mail address.")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Password is required.")]
        [MinLength(8, ErrorMessage = "Please enter a password with minimum 8 characters.")]
        public string Password { get; set; } = null!;
    }
}
