using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CommunityProject.Models;

namespace CommunityProject.Pages.Walk
{
    public class DeleteModel : PageModel
    {
        private readonly CommunityProject.Models.DatabaseContext _context;

        public DeleteModel(CommunityProject.Models.DatabaseContext context)
        {
            _context = context;
        }

        [BindProperty]
        public WalkathonInfo WalkathonInfo { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            WalkathonInfo = await _context.WalkathonInfo.SingleOrDefaultAsync(m => m.ID == id);

            if (WalkathonInfo == null)
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

            WalkathonInfo = await _context.WalkathonInfo.FindAsync(id);

            if (WalkathonInfo != null)
            {
                _context.WalkathonInfo.Remove(WalkathonInfo);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
