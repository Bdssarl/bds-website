using System.ComponentModel.DataAnnotations.Schema;

namespace bds_site_web_version7_.Models
{
    public class Metier
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; } = null!;
        public string NameImageMetier { get;set; }
        public string TitleMetier { get; set; }
        public string DescriptionMetier { get; set;}
        [NotMapped]
        public IFormFile formFile { get; set; }

    }
}
