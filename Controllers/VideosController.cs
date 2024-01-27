using bds_site_web_version7_.Models;
using bds_site_web_version7_.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace bds_site_web_version7_.Controllers
{

    public class VideosController : Controller
    {
        SiteWebBdsDbContext _context;
        IFileUpload _fileUpload;
        public VideosController(SiteWebBdsDbContext context,IFileUpload fileUpload)
        {
            _context = context;
            _fileUpload = fileUpload;
        }

        public async Task<IActionResult> Index()
        {
            return _context.Videos != null ?
                        View(await _context.Videos.ToListAsync()) :
                        Problem("Entity set 'SiteWebBdsDbContext.Videos'  is null.");
        }

        // GET: Departementecoles/Details/5
        public async Task<IActionResult> Details(string? id)
        {
            if (id == null || _context.Videos == null)
            {
                return NotFound();
            }

            var video = await _context.Videos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (video == null)
            {
                return NotFound();
            }

            return View(video);
        }

        // GET: Departementecoles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Departementecoles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Video video)
        {
           
                var fileName = _fileUpload.uploadVideo(video.formFile);
                _context.Add(video);
                await _context.SaveChangesAsync();
                
            
            return View();
        }

        // GET: Departementecoles/Edit/5
        public async Task<IActionResult> Edit(string? id)
        {
            if (id == null || _context.Videos == null)
            {
                return NotFound();
            }

            var video = await _context.Videos.FindAsync(id);
            if (video == null)
            {
                return NotFound();
            }
            return View(video);
        }

        // POST: Departementecoles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, Video video)
        {
            if (id != video.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(video);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VideosExists(video.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(video);
        }

        // GET: Departementecoles/Delete/5
        public async Task<IActionResult> Delete(string? id)
        {
            if (id == null || _context.Videos == null)
            {
                return NotFound();
            }

            var video = await _context.Videos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (video == null)
            {
                return NotFound();
            }

            return View(video);
        }

        // POST: Departementecoles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Videos == null)
            {
                return Problem("Entity set 'SiteWebBdsDbContext.Videos'  is null.");
            }
            var video = await _context.Videos.FindAsync(id);
            if (video != null)
            {
                _context.Videos.Remove(video);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VideosExists(string id)
        {
            return (_context.Videos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }

}
