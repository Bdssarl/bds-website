using bds_site_web_version7_.Models;
using bds_site_web_version7_.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace bds_site_web_version7_.Controllers
{
    public class TemoignagesController : Controller
    {
        private SiteWebBdsDbContext _context;
        private IFileUpload _fileUpload;
        public TemoignagesController(SiteWebBdsDbContext context, IFileUpload fileUpload)
        {
            _context = context;
            _fileUpload = fileUpload;
        }

        public async Task<IActionResult> Index()
        {
            return _context.Temoignages != null ?
                        View(await _context.Temoignages.ToListAsync()) :
                        Problem("Entity set 'SiteWebBdsDbContext.Videos'  is null.");
        }

        // GET: Departementecoles/Details/5
        public async Task<IActionResult> Details(string? id)
        {
            if (id == null || _context.Temoignages == null)
            {
                return NotFound();
            }

            var temoignage = await _context.Temoignages
                .FirstOrDefaultAsync(m => m.Id == id);
            if (temoignage == null)
            {
                return NotFound();
            }

            return View(temoignage);
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
        public async Task<IActionResult> Create(Temoignage temoignage)
        {
            var fileName = _fileUpload.uploadimage(temoignage.formfile, "temoignage");
            temoignage.CheminImageTemoignage = fileName;
            temoignage.RoleTemoignage = fileName;
                _context.Add(temoignage);
                await _context.SaveChangesAsync();
            return View();
        }

        // GET: Departementecoles/Edit/5
        public async Task<IActionResult> Edit(string? id)
        {
            if (id == null || _context.Temoignages == null)
            {
                return NotFound();
            }

            var temoignage = await _context.Temoignages.FindAsync(id);
            if (temoignage == null)
            {
                return NotFound();
            }
            return View(temoignage);
        }

        // POST: Departementecoles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, Temoignage temoignage)
        {
            if (id != temoignage.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(temoignage);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TemoignagesExists(temoignage.Id))
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
            return View(temoignage);
        }

        // GET: Departementecoles/Delete/5
        public async Task<IActionResult> Delete(string? id)
        {
            if (id == null || _context.Temoignages == null)
            {
                return NotFound();
            }

            var temoignage = await _context.Temoignages
                .FirstOrDefaultAsync(m => m.Id == id);
            if (temoignage == null)
            {
                return NotFound();
            }

            return View(temoignage);
        }

        // POST: Departementecoles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Temoignages == null)
            {
                return Problem("Entity set 'SiteWebBdsDbContext.Videos'  is null.");
            }
            var temoignage= await _context.Temoignages.FindAsync(id);
            if (temoignage != null)
            {
                _context.Temoignages.Remove(temoignage);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TemoignagesExists(string id)
        {
            return (_context.Temoignages?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
