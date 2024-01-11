using bds_site_web_version2_.Validations;
using System.ComponentModel.DataAnnotations;

namespace bds_site_web_version2_.Models
{
    public class MessageUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public  string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string ObjetMesage { get; set; }
        public string civilite { get; set; }
        public string DescriptionMessage { get; set; }
       
       
        public string ObjetMessage { get; set; }
        public string TypeStage { get; set; }
        public string DomaineStage { get; set; }
        [Required]
        [StringLength(1000)]
       
        public IFormFile formFile { get; set; }
    }
}
