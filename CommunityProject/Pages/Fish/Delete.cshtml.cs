using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CommunityProject.Models;

namespace CommunityProject.Pages.Fish
{
    public class DeleteModel : PageModel
    {
        private readonly CommunityProject.Models.DatabaseContext _context;

        public DeleteModel(CommunityProject.Models.DatabaseContext context)
        {
            _context = context;
        }

        [BindProperty]
        public FishingDerbyInfo FishingDerbyInfo { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FishingDerbyInfo = await _context.FishingDerbyInfo.SingleOrDefaultAsync(m => m.ID == id);

            if (FishingDerbyInfo == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FishingDerbyInfo = await _context.FishingDerbyInfo.FindAsync(id);

            if (FishingDerbyInfo != null)
            {
                _context.FishingDerbyInfo.Remove(FishingDerbyInfo);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
