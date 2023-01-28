using System.ComponentModel.DataAnnotations;

namespace WinPassManager.Models
{
    internal class Register : Login
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Field 'ConfirmPassword' cannot be empty.")]
        [Display(Name = "ConfirmPassword")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Field 'ConfirmPassword' must be minimum 6 symbols.")]
        public string ConfirmPassword { get; set; } = null!;
    }
}