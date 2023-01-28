using System.ComponentModel.DataAnnotations;

namespace WinPassManager.Models
{
    internal static class ModelState
    {
        public static List<string?> ErrorMessages = new();

        public static bool IsValid<T>(T model)
        {
            if (model is null)
            {
                return false;
            }

            var validationContext = new ValidationContext(model, null, null);
            var results = new List<ValidationResult>();

            if (Validator.TryValidateObject(model, validationContext, results, true))
            {
                return true;
            }
            else
            {
                ErrorMessages = results.Select(x => x.ErrorMessage).ToList();
                return false;
            }
        }
    }
}