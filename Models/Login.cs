using System.ComponentModel.DataAnnotations;

namespace bds_site_web_version7_.Models
{
    public class Login
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

       
    }
}
