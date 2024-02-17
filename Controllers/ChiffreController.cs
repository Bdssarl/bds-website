using bds_site_web_version7_.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
namespace bds_site_web_version7_.Controllers
{
    public class ChiffreController : Controller
    {
        // GET: ChiffresController
        
            private SiteWebBdsDbContext _context;

            public ChiffreController(SiteWebBdsDbContext context)
            {
                _context = context;

            }

            public async Task<IActionResult> Index()
            {
                return _context.Chiffres != null ?
                            View(await _context.Chiffres.ToListAsync()) :
                            Problem("Entity set 'SiteWebBdsDbContext.Chiffres'  is null.");
            }

        // GET: Departementecoles/Details/5


        // GET: Departementecoles/Create
        [Authorize]
            public IActionResult Create()
            {
                return View();
            }

        // POST: Departementecoles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Create(Chiffre chiffre)
            {

                _context.Add(chiffre);
                await _context.SaveChangesAsync();
                return View();
            }






        }
    }
