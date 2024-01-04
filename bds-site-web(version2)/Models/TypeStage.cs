using Bds_site_web.Models;

namespace bds_site_web_version2_.Models
{
    public class TypeStage
    {
        public string IdTypeStage { get; set; } = null!;
        public string LibelleTypeStage { get; set; }=null!;
        public virtual ICollection<Stage> Stages { get;set; } = new List<Stage>();

    }
}
