using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace bds_site_web_version7_.Models
{
    public class PartenaireListViewComponent:ViewComponent
    {
        private readonly  SiteWebBdsDbContext _context;
        public PartenaireListViewComponent(SiteWebBdsDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var partenaires = await _context.Partenaires.ToListAsync();
            return View(partenaires);
        }

    }
}
