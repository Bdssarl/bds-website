namespace bds_site_web_version7_.Models
{
    public class UserNewsletter
    {
        public string EmailUser { get; set; } = null!;
        public virtual ICollection<Newsletter> Newsletters { get; }= new List<Newsletter>();
    }
}
