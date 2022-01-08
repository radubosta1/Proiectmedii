using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ServiceAuto1.Data;
using ServiceAuto1.Models;

namespace ServiceAuto1.Pages.Reviews
{
    public class IndexModel : PageModel
    {
        private readonly ServiceAuto1.Data.ServiceAuto1Context _context;

        public IndexModel(ServiceAuto1.Data.ServiceAuto1Context context)
        {
            _context = context;
        }

        public IList<Review> Review { get;set; }

        public async Task OnGetAsync()
        {
            Review = await _context.Review
                .Include(r => r.Client).ToListAsync();
        }
    }
}
