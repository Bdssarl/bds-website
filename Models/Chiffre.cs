
using System.ComponentModel.DataAnnotations.Schema;

namespace bds_site_web_version7_.Models
{
    public class Chiffre
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string  AnneeExperience{get;set;}
        public string NombreProjetsRealises { get; set; }
        public string NombreEntreprisePartenaires { get; set; }
    }
}
