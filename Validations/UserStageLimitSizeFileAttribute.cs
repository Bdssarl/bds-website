using bds_site_web_version2_.Models;
using System.ComponentModel.DataAnnotations;

namespace bds_site_web_version2_.Validations
{
    public class UserStageLimitSizeFileAttribute:ValidationAttribute
    {
        public int _size { get;  }
        public UserStageLimitSizeFileAttribute(int size) => _size = size;
        public string GetErrorMessage() => $"la taille de votre fichier ne doit pas excéder {_size}Mo";
        protected override ValidationResult? IsValid(
 object? value, ValidationContext validationContext)
        {
            var userStage = (UserStage)validationContext.ObjectInstance;
            
            if (userStage.formFile.Length > 2097152)
            {
                return new ValidationResult(GetErrorMessage());
            }
            return ValidationResult.Success;
        }

    }
}
