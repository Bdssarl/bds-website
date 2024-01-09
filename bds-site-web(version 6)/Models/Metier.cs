using System.ComponentModel.DataAnnotations.Schema;

namespace Bds_site_web.Models
{
    public class Metier
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; } = null!;
        public string NameImageMetier { get;set; }=null!;
        public string CheminImageMetier { get; set; } = null!;
        public string TitleMetier { get; set; } = null!;
        public string DescriptionMetier { get; set;} = null!;
      
    }
}
