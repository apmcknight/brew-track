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
    public class IndexModel : PageModel
    {
        private readonly OrdersDatabaseContext _context;

        public IndexModel(OrdersDatabaseContext context)
        {
            _context = context;
        }

        public IList<Orders> Orders { get;set; }

        public async Task OnGetAsync()
        {
            Orders = await _context.Orders.ToListAsync();
        }
    }
}
