using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace bds_site_web_version7_.Models
{
    public class MetierListViewComponent:ViewComponent
    {
        private readonly SiteWebBdsDbContext _context;
        public MetierListViewComponent(SiteWebBdsDbContext context)
        {
             _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var metiers = await _context.Metiers.ToListAsync();
            return View(metiers);
        }
    }
}
