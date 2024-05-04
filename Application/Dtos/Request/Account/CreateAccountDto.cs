using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
