using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CommunityProject.Models;

namespace CommunityProject.Pages.Bowl
{
    public class CreateModel : PageModel
    {
        private readonly CommunityProject.Models.DatabaseContext _context;

        public CreateModel(CommunityProject.Models.DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public BowlathonInfo BowlathonInfo { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.BowlathonInfo.Add(BowlathonInfo);
            await _context.SaveChangesAsync();

            // return RedirectToPage("./Index");
            return RedirectToPage("../submit");
        }
    }
}