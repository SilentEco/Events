using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inlämningsuppgift1.Data;
using Inlämningsuppgift1.Models;
using Microsoft.EntityFrameworkCore;

namespace Inlämningsuppgift1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Inlämningsuppgift1.Data.eventsDbContext _context;
        public IndexModel(Inlämningsuppgift1.Data.eventsDbContext context)
        {
            _context = context;
        }
        public IList<Event> Event { get; set; }

        public async Task OnGetAsync()
        {
            Event = await _context.Event.ToListAsync();
        }
    }
}
