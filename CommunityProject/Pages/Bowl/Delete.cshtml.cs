using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CommunityProject.Models;

namespace CommunityProject.Pages.Bowl
{
    public class DeleteModel : PageModel
    {
        private readonly CommunityProject.Models.DatabaseContext _context;

        public DeleteModel(CommunityProject.Models.DatabaseContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BowlathonInfo BowlathonInfo { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BowlathonInfo = await _context.BowlathonInfo.SingleOrDefaultAsync(m => m.ID == id);

            if (BowlathonInfo == null)
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

            BowlathonInfo = await _context.BowlathonInfo.FindAsync(id);

            if (BowlathonInfo != null)
            {
                _context.BowlathonInfo.Remove(BowlathonInfo);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
