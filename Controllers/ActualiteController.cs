using bds_site_web_version7_.Models;
using bds_site_web_version7_.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.AccessControl;

namespace bds_site_web_version7_.Controllers
{
    public class ActualiteController : Controller
    {
        private readonly SiteWebBdsDbContext _context;
        private readonly IFileUpload _fileUpload;
        public ActualiteController(SiteWebBdsDbContext context,IFileUpload fileUpload) { 
            _context= context;
            _fileUpload = fileUpload;
        }
        //GET:Actualite
        public async Task<IActionResult> Index()
        {
            return _context.Actualites!= null ?
                        View(await _context.Actualites.ToListAsync()) :
                        Problem("Entity set 'SiteWebBdsDbContext.Actualites'  is null.");
        }
        // GET: Actualite/Details/5
        public async Task<IActionResult> Details(string? id)
        {
            if (id == null || _context.Actualites == null)
            {
                return NotFound();
            }

            var actualite= await _context.Actualites
                .FirstOrDefaultAsync(m => m.Id == id);
            if (actualite == null)
            {
                return NotFound();
            }


            return View(actualite);
        }
        // GET: Actualite/Edit/5
        public async Task<IActionResult> Edit(string? id)
        {
            if (id == null || _context.Actualites == null)
            {
                return NotFound();
            }

            var actualite = await _context.Actualites.FindAsync(id);
            if (actualite == null)
            {
                return NotFound();
            }
            return View(actualite);
        }

        // POST: Actualite/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, Actualite actualite)
        {
            if (id != actualite.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(actualite);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ActualiteExists(actualite.Id))
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
            return View(actualite);
        }




        [Authorize]
        public IActionResult Create()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Create(Actualite actualite) {
            if (ModelState.IsValid)
            {

                var fileName = _fileUpload.uploadimage(actualite.FormFile, "actualite");
                actualite.CheminMediaActualite = fileName;
                actualite.dateCreation = DateTime.Now;
                _context.Add(actualite);

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(actualite);
        }


        public  IActionResult Matrix()
        {
            return View();
        }
        public IActionResult Excel()
        {
            return View();
        }

        private bool ActualiteExists(string id)
        {
            return (_context.Actualites?.Any(e => e.Id == id)).GetValueOrDefault();
        }

    }
}
