using System.ComponentModel.DataAnnotations;

namespace WinPassManager.Models
{
    public class Login
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Field 'UserName' cannot be empty.")]
        [Display(Name = "UserName")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Field 'UserName' must be EmailAddress.")]
        [RegularExpression(
            @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
            ErrorMessage = "Field 'UserName' must be EmailAddress.")]
        public string UserName { get; set; } = null!;

        [Required(AllowEmptyStrings = false, ErrorMessage = "Field 'Password' cannot be empty.")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Field 'Password' must be minimum 6 symbols.")]
        public string Password { get; set; } = null!;
    }
}