using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace bds_site_web_version7_.Models
{
    public class ActualiteListViewComponent:ViewComponent
    {
        private readonly SiteWebBdsDbContext _context;
        public ActualiteListViewComponent(SiteWebBdsDbContext context) {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var actualites = await _context.Actualites.ToListAsync();

            return View(actualites);
        }
    }
}
