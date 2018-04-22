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
    public class IndexModel : PageModel
    {
        private readonly CommunityProject.Models.DatabaseContext _context;

        public IndexModel(CommunityProject.Models.DatabaseContext context)
        {
            _context = context;
        }

        public IList<FishingDerbyInfo> FishingDerbyInfo { get;set; }

        public async Task OnGetAsync()
        {
            FishingDerbyInfo = await _context.FishingDerbyInfo.ToListAsync();
        }
    }
}
