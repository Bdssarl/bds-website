using bds_site_web_version7_.Models;
using System.ComponentModel.DataAnnotations;

namespace bds_site_web_version7_.Validations
{
    public class UserStageValidExtension:ValidationAttribute
    {
        
        public UserStageValidExtension()
        {

        }
        public string GetErrorMessage() => $"veuillez inserez un fichier avec l'une des extensions suivantes:pdf ,txt";
        protected override ValidationResult? IsValid(
object? value, ValidationContext validationContext)
        {
            if (HasExtension(validationContext))
            {
                return ValidationResult.Success;
            }
            
            return new ValidationResult(GetErrorMessage());
        }
        public  Boolean HasExtension(ValidationContext validationContext)
        {
             var userStage = (UserStage)validationContext.ObjectInstance;
            string extension = Path.GetExtension(userStage.formFile.FileName).ToLowerInvariant();
            string[] permittedExtensions = { ".txt", ".pdf" };
            

            return (permittedExtensions.Contains(extension) ? true : false);
        }
        
    }
}
