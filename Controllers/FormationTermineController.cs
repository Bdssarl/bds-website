using bds_site_web_version7_.Models;
using bds_site_web_version7_.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace bds_site_web_version7_.Controllers
{
    
    public class FormationTermineController : Controller
    {
            SiteWebBdsDbContext _context;
        private static int i = 0;
            IFileUpload _fileUpload;
            public FormationTermineController(SiteWebBdsDbContext context, IFileUpload fileUpload)
            {
                _context = context;
                _fileUpload = fileUpload;
            i = _context.FormationTermines.Count();
            if (i == 0)
            {
                i = 1;
            }
            else
            {
                i = i + 1;
            }
        }
        //GET:FormationTermine
            public async Task<IActionResult> Index()
            {
                return _context.Videos != null ?
                            View(await _context.FormationTermines.ToListAsync()) :
                            Problem("Entity set 'SiteWebBdsDbContext.FormationTermines'  is null.");
            }

            // GET: FormationTermine/Details/5
            public async Task<IActionResult> Details(string? id)
            {
                if (id == null || _context.FormationTermines == null)
                {
                    return NotFound();
                }

                var formation = await _context.FormationTermines
                    .FirstOrDefaultAsync(m => m.Id == id);
                if (formation == null)
                {
                    return NotFound();
                }

                return View(formation);
            }

            // GET: FormationTermine/Create
            public IActionResult Create()
            {
            
            var formation = new FormationTermine();
                formation.Id = $"ft{DateTime.Now.Year}{i}";
            
            return View(formation);
            }

        // POST: FormationTermine/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Create(FormationTermine formation)
            {
            if (ModelState.IsValid)
            {
                var fileName = _fileUpload.uploadimage(formation.FormFile, "formation");
                formation.CheminImage = fileName;
                _context.Add(formation);

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
                return View(formation);
            }
        public async Task<IActionResult> FormationTermine()
        {
           
            return View();
        }

            // GET: FormationTermine/Edit/5
            public async Task<IActionResult> Edit(string? id)
            {
                if (id == null || _context.FormationTermines == null)
                {
                    return NotFound();
                }

                var formation = await _context.FormationTermines.FindAsync(id);
                if (formation == null)
                {
                    return NotFound();
                }
                return View(formation);
            }

            // POST: FormationTermine/Edit/5
            // To protect from overposting attacks, enable the specific properties you want to bind to.
            // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Edit(string id, FormationTermine formation)
            {
                if (id != formation.Id)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    try
                    {
                        _context.Update(formation);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!FormationTerminesExists(formation.Id))
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
                return View(formation);
            }

            // GET: FormationTermine/Delete/5
            public async Task<IActionResult> Delete(string? id)
            {
                if (id == null || _context.FormationTermines == null)
                {
                    return NotFound();
                }

                var formation = await _context.FormationTermines
                    .FirstOrDefaultAsync(m => m.Id == id);
                if (formation == null)
                {
                    return NotFound();
                }

                return View(formation);
            }

            // POST: FormationTermine/Delete/5
            [HttpPost, ActionName("Delete")]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> DeleteConfirmed(string id)
            {
                if (_context.Videos == null)
                {
                    return Problem("Entity set 'SiteWebBdsDbContext.FormationTermines'  is null.");
                }
                var formation = await _context.FormationTermines.FindAsync(id);
                if (formation != null)
                {
                    _context.FormationTermines.Remove(formation);
                }

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            private bool FormationTerminesExists(string id)
            {
                return (_context.FormationTermines?.Any(e => e.Id == id)).GetValueOrDefault();
            }
        }

    }

