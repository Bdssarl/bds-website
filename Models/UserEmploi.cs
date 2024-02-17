using bds_site_web_version7_.Validations;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace bds_site_web_version7_.Models
{
    
    
        [NotMapped]
        [BindRequired]
        public class UserEmploi
        {
        [StringLength(255, ErrorMessage = "la taille ne doit pas dépasser 255 caractères")]
        public string FirstName { get; set; }
        [StringLength(255, ErrorMessage = "la taille ne doit pas dépasser 255 caractères")]
        public string LastName { get; set; }
            public string Email { get; set; }
            public string civilite { get; set; }
        [StringLength(255, ErrorMessage = "la taille ne doit pas dépasser 255 caractères")]
        public string PhoneNumber { get; set; }
            public string ObjetMessage { get; set; }
            public string TypeEmploi { get; set; }
            public string DomaineEmploi { get; set; }
            [Required]
            public string DescriptionMessage { get; set; }
           
            
            public IFormFile formFile { get; set; }
        }
}
