
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bds_site_web_version7_.Models
{
    public class Chiffre
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        [StringLength(4,ErrorMessage ="vous avez atteint la taille limite")]
        public string  AnneeExperience{get;set;}
        [StringLength(25,ErrorMessage ="vous avez atteint la taille limite")]
        public string NombreProjetsRealises { get; set; }
        [StringLength(50,ErrorMessage ="vous avez atteint la taille limite")]
        public string NombreEntreprisePartenaires { get; set; }
    }
}
