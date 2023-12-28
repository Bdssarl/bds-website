namespace Bds_site_web.Models
{
    public class UserNewsletter
    {
        public string EmailUser { get; set; } = null!;
        public virtual ICollection<Newsletter> Newsletters { get; }= new List<Newsletter>();
    }
}
