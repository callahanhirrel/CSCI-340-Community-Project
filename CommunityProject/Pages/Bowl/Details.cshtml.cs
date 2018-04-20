using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CommunityProject.Models;

namespace CommunityProject.Pages.bowlathon
{
    public class DetailsModel : PageModel
    {
        private readonly CommunityProject.Models.DatabaseContext _context;

        public DetailsModel(CommunityProject.Models.DatabaseContext context)
        {
            _context = context;
        }

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
    }
}
