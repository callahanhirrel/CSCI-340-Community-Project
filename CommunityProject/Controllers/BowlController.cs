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
    public class BowlController : Controller
    {
        private readonly DatabaseContext _context;

        public BowlController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: Bowl
        public async Task<IActionResult> Index()
        {
            return View(await _context.BowlathonInfo.ToListAsync());
        }

        // GET: Bowl/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bowlathonInfo = await _context.BowlathonInfo
                .SingleOrDefaultAsync(m => m.ID == id);
            if (bowlathonInfo == null)
            {
                return NotFound();
            }

            return View(bowlathonInfo);
        }

        // GET: Bowl/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Bowl/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,CustID,TeamID,Payment")] BowlathonInfo bowlathonInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bowlathonInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bowlathonInfo);
        }

        // GET: Bowl/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bowlathonInfo = await _context.BowlathonInfo.SingleOrDefaultAsync(m => m.ID == id);
            if (bowlathonInfo == null)
            {
                return NotFound();
            }
            return View(bowlathonInfo);
        }

        // POST: Bowl/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,CustID,TeamID,Payment")] BowlathonInfo bowlathonInfo)
        {
            if (id != bowlathonInfo.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bowlathonInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BowlathonInfoExists(bowlathonInfo.ID))
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
            return View(bowlathonInfo);
        }

        // GET: Bowl/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bowlathonInfo = await _context.BowlathonInfo
                .SingleOrDefaultAsync(m => m.ID == id);
            if (bowlathonInfo == null)
            {
                return NotFound();
            }

            return View(bowlathonInfo);
        }

        // POST: Bowl/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bowlathonInfo = await _context.BowlathonInfo.SingleOrDefaultAsync(m => m.ID == id);
            _context.BowlathonInfo.Remove(bowlathonInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BowlathonInfoExists(int id)
        {
            return _context.BowlathonInfo.Any(e => e.ID == id);
        }
    }
}
