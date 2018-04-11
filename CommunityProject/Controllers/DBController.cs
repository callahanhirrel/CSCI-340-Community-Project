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
    public class DBController : Controller
    {
        private readonly DatabaseContext _context;

        public DBController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: DB
        public async Task<IActionResult> Index()
        {
            return View(await _context.GenInfo.ToListAsync());
        }

        // GET: DB/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var genInfo = await _context.GenInfo
                .SingleOrDefaultAsync(m => m.ID == id);
            if (genInfo == null)
            {
                return NotFound();
            }

            return View(genInfo);
        }

        // GET: DB/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DB/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,FirstName,LastName,Email,Phone,Address,City,State,ZIP,ShirtSize,PicConsent")] GenInfo genInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(genInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(genInfo);
        }

        // GET: DB/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var genInfo = await _context.GenInfo.SingleOrDefaultAsync(m => m.ID == id);
            if (genInfo == null)
            {
                return NotFound();
            }
            return View(genInfo);
        }

        // POST: DB/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,FirstName,LastName,Email,Phone,Address,City,State,ZIP,ShirtSize,PicConsent")] GenInfo genInfo)
        {
            if (id != genInfo.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(genInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GenInfoExists(genInfo.ID))
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
            return View(genInfo);
        }

        // GET: DB/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var genInfo = await _context.GenInfo
                .SingleOrDefaultAsync(m => m.ID == id);
            if (genInfo == null)
            {
                return NotFound();
            }

            return View(genInfo);
        }

        // POST: DB/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var genInfo = await _context.GenInfo.SingleOrDefaultAsync(m => m.ID == id);
            _context.GenInfo.Remove(genInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GenInfoExists(int id)
        {
            return _context.GenInfo.Any(e => e.ID == id);
        }
    }
}
