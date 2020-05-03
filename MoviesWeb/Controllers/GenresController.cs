using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ExercicioEFCoreCodeFirst.PL;
using Microsoft.EntityFrameworkCore;
using ExercicioEFCoreCodeFirst.BLL;

namespace MoviesWeb.Controllers
{
    public class GenresController : Controller
    {
        private readonly MovieContext _context;
        private readonly MovieFacade facade;

        public GenresController(MovieContext context)
        {
            _context = context;
            facade = new MovieFacade();
        }

        // GET: Genres
        public async Task<IActionResult> Index()
        {
            return View(await facade.Index());
        }

        // GET: Genres/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //chamar fachada aqui
            //var genre = flemis.facade(m => m.GenreID == ID);
            var genre = await facade.DetailsAsync(id);

            if (genre == null)
            {
                return NotFound();
            }

            return View(genre);
        }

        // GET: Genres/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Genres/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GenreID,Name,Description")] Genre genre)
        {
            if (ModelState.IsValid)
            {
                //chamar fachada aqui
                await facade.addGenreAsync(genre);
                return RedirectToAction(nameof(Index));
            }
            return View(genre);
        }

        // GET: Genres/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //chamar fachada aqui
            var genre = await facade.editAsync(id);

            if (genre == null)
            {
                return NotFound();
            }
            return View(genre);
        }

        // POST: Genres/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,
            [Bind("GenreID,Name,Description")] Genre genre)
        {
            if (id != genre.GenreID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    //chamar fachada aqui
                    await facade.EditAsyncGenre(genre);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GenreExists(genre.GenreID))
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
            return View(genre);
        }

        // GET: Genres/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //chamar fachada aqui
            var genre = await facade.DeleteAsync(id);

            if (genre == null)
            {
                return NotFound();
            }

            return View(genre);
        }

        // POST: Genres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await facade.DeleteConfirmedAsync(id);

            return RedirectToAction(nameof(Index));
        }

        private bool GenreExists(int id)
        {
            return facade.GenreExists(id);
        }
    }
}
