using Bds_site_web.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace bds_site_web_version2_.Models
{
    public class TypeStage
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; } = null!;
        public string LibelleTypeStage { get; set; }=null!;
        public virtual ICollection<Stage> Stages { get; set; } = new List<Stage>();
        public virtual ICollection<StageTypeStage> StageTypeStages { get; set; } = new List<StageTypeStage>();
    }
}
