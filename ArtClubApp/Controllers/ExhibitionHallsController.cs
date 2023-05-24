using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ArtClubApp.Data;
using ArtClubApp.Models;

namespace ArtClubApp.Controllers
{
    public class ExhibitionHallsController : Controller
    {
        private readonly ArtClubContext _context;

        public ExhibitionHallsController(ArtClubContext context)
        {
            _context = context;
        }

        // GET: ExhibitionHalls
        public async Task<IActionResult> Index()
        {
              return _context.ExhibitionHalls != null ? 
                          View(await _context.ExhibitionHalls.ToListAsync()) :
                          Problem("Entity set 'ArtClubContext.ExhibitionHalls'  is null.");
        }

        // GET: ExhibitionHalls/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ExhibitionHalls == null)
            {
                return NotFound();
            }

            var exhibitionHall = await _context.ExhibitionHalls
                .FirstOrDefaultAsync(m => m.ExhibitionHall_Id == id);
            if (exhibitionHall == null)
            {
                return NotFound();
            }

            return View(exhibitionHall);
        }

        // GET: ExhibitionHalls/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ExhibitionHalls/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ExhibitionHall_Id,Name,Location,Rent")] ExhibitionHall exhibitionHall)
        {
            if (ModelState.IsValid)
            {
                _context.Add(exhibitionHall);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(exhibitionHall);
        }

        // GET: ExhibitionHalls/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ExhibitionHalls == null)
            {
                return NotFound();
            }

            var exhibitionHall = await _context.ExhibitionHalls.FindAsync(id);
            if (exhibitionHall == null)
            {
                return NotFound();
            }
            return View(exhibitionHall);
        }

        // POST: ExhibitionHalls/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ExhibitionHall_Id,Name,Location,Rent")] ExhibitionHall exhibitionHall)
        {
            if (id != exhibitionHall.ExhibitionHall_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(exhibitionHall);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExhibitionHallExists(exhibitionHall.ExhibitionHall_Id))
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
            return View(exhibitionHall);
        }

        // GET: ExhibitionHalls/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ExhibitionHalls == null)
            {
                return NotFound();
            }

            var exhibitionHall = await _context.ExhibitionHalls
                .FirstOrDefaultAsync(m => m.ExhibitionHall_Id == id);
            if (exhibitionHall == null)
            {
                return NotFound();
            }

            return View(exhibitionHall);
        }

        // POST: ExhibitionHalls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ExhibitionHalls == null)
            {
                return Problem("Entity set 'ArtClubContext.ExhibitionHalls'  is null.");
            }
            var exhibitionHall = await _context.ExhibitionHalls.FindAsync(id);
            if (exhibitionHall != null)
            {
                _context.ExhibitionHalls.Remove(exhibitionHall);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExhibitionHallExists(int id)
        {
          return (_context.ExhibitionHalls?.Any(e => e.ExhibitionHall_Id == id)).GetValueOrDefault();
        }
    }
}
