using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ServiceAuto1.Data;
using ServiceAuto1.Models;

namespace ServiceAuto1.Pages.Facturi
{
    public class DetailsModel : PageModel
    {
        private readonly ServiceAuto1.Data.ServiceAuto1Context _context;

        public DetailsModel(ServiceAuto1.Data.ServiceAuto1Context context)
        {
            _context = context;
        }

        public Factura Factura { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Factura = await _context.Factura.FirstOrDefaultAsync(m => m.ID == id);

            if (Factura == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
