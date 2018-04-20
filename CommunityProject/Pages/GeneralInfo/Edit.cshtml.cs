using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CommunityProject.Models;

namespace CommunityProject.Pages.GeneralInfo
{
    public class EditModel : PageModel
    {
        private readonly CommunityProject.Models.DatabaseContext _context;

        public EditModel(CommunityProject.Models.DatabaseContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(GenInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                
            }

            return RedirectToPage("./Index");
        }
    }
}
