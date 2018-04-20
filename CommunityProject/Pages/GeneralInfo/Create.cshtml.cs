using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CommunityProject.Models;

namespace CommunityProject.Pages.GeneralInfo
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
        public GenInfo GenInfo { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.GenInfo.Add(GenInfo);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}