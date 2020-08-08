using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using brew_track.Models;

namespace brew_track.Pages.Order
{
    public class DetailsModel : PageModel
    {
        private readonly OrdersDatabaseContext _context;

        public DetailsModel(OrdersDatabaseContext context)
        {
            _context = context;
        }

        public Orders Orders { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Orders = await _context.Orders.FirstOrDefaultAsync(m => m.ID == id);

            if (Orders == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
