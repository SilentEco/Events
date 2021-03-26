using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Inlämningsuppgift1.Data;
using Inlämningsuppgift1.Models;

namespace Inlämningsuppgift1.Pages
{
    public class MyEventsModel : PageModel
    {
        private readonly Inlämningsuppgift1.Data.eventsDbContext _context;

        public MyEventsModel(Inlämningsuppgift1.Data.eventsDbContext context)
        {
            _context = context;
        }

        public Attendee Attendee { get;set; }

        public async Task OnGetAsync()
        {
            Attendee = await _context.Attendee.Where(a => a.attendeeID == 1).Include(e => e.events).FirstOrDefaultAsync();
        }
    }
}
