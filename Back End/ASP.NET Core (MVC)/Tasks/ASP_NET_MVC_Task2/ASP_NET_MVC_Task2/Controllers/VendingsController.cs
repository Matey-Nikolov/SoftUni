#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASP_NET_MVC_Task2.Models;

namespace ASP_NET_MVC_Task2.Controllers
{
    public class VendingsController : Controller
    {
        private readonly VendingMachineContext _context;

        public VendingsController(VendingMachineContext context)
        {
            _context = context;
        }

        // GET: Vendings
        public async Task<IActionResult> Index()
        {
            return View(await _context.Vendings.ToListAsync());
        }

        // GET: Vendings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vending = await _context.Vendings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vending == null)
            {
                return NotFound();
            }

            return View(vending);
        }

        // GET: Vendings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Vendings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Lat,Lot,Date")] Vending vending)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vending);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vending);
        }

        // GET: Vendings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vending = await _context.Vendings.FindAsync(id);
            if (vending == null)
            {
                return NotFound();
            }
            return View(vending);
        }

        // POST: Vendings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Lat,Lot,Date")] Vending vending)
        {
            if (id != vending.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vending);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VendingExists(vending.Id))
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
            return View(vending);
        }

        // GET: Vendings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vending = await _context.Vendings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vending == null)
            {
                return NotFound();
            }

            return View(vending);
        }

        // POST: Vendings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vending = await _context.Vendings.FindAsync(id);
            _context.Vendings.Remove(vending);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VendingExists(int id)
        {
            return _context.Vendings.Any(e => e.Id == id);
        }
    }
}
