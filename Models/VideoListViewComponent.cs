using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace bds_site_web_version7_.Models
{
    public class VideoListViewComponent:ViewComponent
    {
        private readonly SiteWebBdsDbContext _context;
        public VideoListViewComponent(SiteWebBdsDbContext context)
        {
            _context = context;
        }
        public async  Task<IViewComponentResult> InvokeAsync()
        {
            var videos = await _context.Videos.ToListAsync();
            return View(videos);
        }
    }
}
