using Bds_site_web.Models;

namespace bds_site_web_version2_.Models
{
    public class StageTypeStage
    {

        public virtual ICollection<Stage> Stages { get; set; } = new List<Stage>();
        public virtual ICollection<TypeStage> TypeStages { get; set; } = new List<TypeStage>();
    }
}
