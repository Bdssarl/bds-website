using bds_site_web_version7_.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bds_site_web_version7_.Models
{
    public class TypeStage
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; } = null!;
        [StringLength(255, ErrorMessage = "vous avez atteint la taille limite ")]
        public string LibelleTypeStage { get; set; }=null!;
        [NotMapped]
        public string DomaineStage { get; set; } = null!;
        public virtual ICollection<Stage> Stages { get; set; } = new List<Stage>();
       
    }
}
