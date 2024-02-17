using bds_site_web_version7_.Validations;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bds_site_web_version7_.Models
{
    [NotMapped]
    [BindRequired]
    public class UserStage
    {
        
        [StringLength(255,ErrorMessage="la taille ne doit pas dépasser 255 caractères")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(255, ErrorMessage="la taille ne doit pas dépasser 255 caractères")]
        public string LastName { get; set; }
        [Required]
        [StringLength(255, ErrorMessage = "la taille ne doit pas dépasser 255 caractères")]
        public string Email { get; set; }
        [Required]
        [StringLength(255, ErrorMessage = "la taille ne doit pas dépasser 255 caractères")]
        public string civilite { get; set; }
        [Required]
        [StringLength(45)]
        public string PhoneNumber { get; set; }
        [Required]
        [StringLength(45, ErrorMessage = "la taille ne doit pas dépasser 255 caractères")]
        public string ObjetMessage { get; set; }
        public string TypeStage { get; set; }
        public string DomaineStage { get; set; }
        [Required]
        [StringLength(1000)]
        public string DescriptionMessage { get; set; }
        
       
        public IFormFile formFile { get; set; }
    }
}
