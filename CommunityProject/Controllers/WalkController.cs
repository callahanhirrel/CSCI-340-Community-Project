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
    public class WalkController : Controller
    {
        private readonly DatabaseContext _context;

        public WalkController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: Walk
        public async Task<IActionResult> Index()
        {
            return View(await _context.WalkathonInfo.ToListAsync());
        }

        // GET: Walk/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var walkathonInfo = await _context.WalkathonInfo
                .SingleOrDefaultAsync(m => m.ID == id);
            if (walkathonInfo == null)
            {
                return NotFound();
            }

            return View(walkathonInfo);
        }

        // GET: Walk/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Walk/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,CustID,Payment")] WalkathonInfo walkathonInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(walkathonInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(walkathonInfo);
        }

        // GET: Walk/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var walkathonInfo = await _context.WalkathonInfo.SingleOrDefaultAsync(m => m.ID == id);
            if (walkathonInfo == null)
            {
                return NotFound();
            }
            return View(walkathonInfo);
        }

        // POST: Walk/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,CustID,Payment")] WalkathonInfo walkathonInfo)
        {
            if (id != walkathonInfo.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(walkathonInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WalkathonInfoExists(walkathonInfo.ID))
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
            return View(walkathonInfo);
        }

        // GET: Walk/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var walkathonInfo = await _context.WalkathonInfo
                .SingleOrDefaultAsync(m => m.ID == id);
            if (walkathonInfo == null)
            {
                return NotFound();
            }

            return View(walkathonInfo);
        }

        // POST: Walk/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var walkathonInfo = await _context.WalkathonInfo.SingleOrDefaultAsync(m => m.ID == id);
            _context.WalkathonInfo.Remove(walkathonInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WalkathonInfoExists(int id)
        {
            return _context.WalkathonInfo.Any(e => e.ID == id);
        }
    }
}
