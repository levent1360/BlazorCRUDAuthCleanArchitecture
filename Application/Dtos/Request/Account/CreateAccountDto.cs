using System.ComponentModel.DataAnnotations;

namespace Application.Dtos.Request.Account
{
    public class CreateAccountDto: LoginDto
    {
        [Required]
        public string Name { get; set; }
        [Required, Compare(nameof(Password))]
        public string ConfirmPasword { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
    }
}
