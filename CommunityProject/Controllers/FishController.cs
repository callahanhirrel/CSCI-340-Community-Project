using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CommunityProject.Models;

namespace CommunityProject.Controllers
{
    public class FishController : Controller
    {
        private readonly DatabaseContext _context;

        public FishController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: Fish
        public async Task<IActionResult> Index()
        {
            return View(await _context.FishingDerbyInfo.ToListAsync());
        }

        // GET: Fish/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fishingDerbyInfo = await _context.FishingDerbyInfo
                .SingleOrDefaultAsync(m => m.ID == id);
            if (fishingDerbyInfo == null)
            {
                return NotFound();
            }

            return View(fishingDerbyInfo);
        }

        // GET: Fish/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Fish/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,CustID,Consent")] FishingDerbyInfo fishingDerbyInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fishingDerbyInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fishingDerbyInfo);
        }

        // GET: Fish/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fishingDerbyInfo = await _context.FishingDerbyInfo.SingleOrDefaultAsync(m => m.ID == id);
            if (fishingDerbyInfo == null)
            {
                return NotFound();
            }
            return View(fishingDerbyInfo);
        }

        // POST: Fish/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,CustID,Consent")] FishingDerbyInfo fishingDerbyInfo)
        {
            if (id != fishingDerbyInfo.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fishingDerbyInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FishingDerbyInfoExists(fishingDerbyInfo.ID))
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
            return View(fishingDerbyInfo);
        }

        // GET: Fish/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fishingDerbyInfo = await _context.FishingDerbyInfo
                .SingleOrDefaultAsync(m => m.ID == id);
            if (fishingDerbyInfo == null)
            {
                return NotFound();
            }

            return View(fishingDerbyInfo);
        }

        // POST: Fish/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fishingDerbyInfo = await _context.FishingDerbyInfo.SingleOrDefaultAsync(m => m.ID == id);
            _context.FishingDerbyInfo.Remove(fishingDerbyInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FishingDerbyInfoExists(int id)
        {
            return _context.FishingDerbyInfo.Any(e => e.ID == id);
        }
    }
}
