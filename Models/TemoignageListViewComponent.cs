using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace bds_site_web_version7_.Models
{
    public class TemoignageListViewComponent:ViewComponent
    {
        private readonly SiteWebBdsDbContext _context;
        public TemoignageListViewComponent(SiteWebBdsDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var temoignages = await _context.Temoignages.ToListAsync();
            return View(temoignages);
        }
    }
}
