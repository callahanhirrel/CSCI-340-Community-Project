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
    public class DetailsModel : PageModel
    {
        private readonly CommunityProject.Models.DatabaseContext _context;

        public DetailsModel(CommunityProject.Models.DatabaseContext context)
        {
            _context = context;
        }

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
    }
}
