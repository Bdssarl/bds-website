using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bds_site_web_version7_.Models
{
    public class Metier
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; } = null!;
        public string NameImageMetier { get;set; }
        public string TitleMetier { get; set; }
        [StringLength(255, ErrorMessage = "vous avez atteint la taille limite ")]
        public string DescriptionMetier { get; set;}
        [StringLength(255, ErrorMessage = "vous avez atteint la taille limite ")]
        public string nomPageMetier { get; set; }
        [NotMapped]
        public IFormFile formFile { get; set; }

    }
}
