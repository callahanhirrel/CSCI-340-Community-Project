using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CommunityProject.Models;

namespace CommunityProject.Pages.GeneralInfo
{
    public class DeleteModel : PageModel
    {
        private readonly CommunityProject.Models.DatabaseContext _context;

        public DeleteModel(CommunityProject.Models.DatabaseContext context)
        {
            _context = context;
        }

        [BindProperty]
        public GenInfo GenInfo { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            GenInfo = await _context.GenInfo.SingleOrDefaultAsync(m => m.ID == id);

            if (GenInfo == null)
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

            GenInfo = await _context.GenInfo.FindAsync(id);

            if (GenInfo != null)
            {
                _context.GenInfo.Remove(GenInfo);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
