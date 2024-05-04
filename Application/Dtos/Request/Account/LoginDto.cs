using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Application.Dtos.Request.Account
{
    public class LoginDto
    {
        [EmailAddress, Required]
        [RegularExpression("[^@ \\t\\r\\n]+@[^@ \\t\\r\\n]+\\.[^@ \\t\\r\\n]+")]
        [DisplayName("Email Address")]
        public string EmailAddress { get; set; } = string.Empty;
        [Required]
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$ %^&*-]).{8,}$")]
        public string Password { get; set; } = string.Empty;
    }
}
