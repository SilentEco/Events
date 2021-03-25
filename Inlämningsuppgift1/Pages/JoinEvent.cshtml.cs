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
    public class JoinEventModel : PageModel
    {
        private readonly Inlämningsuppgift1.Data.eventsDbContext _context;

        public JoinEventModel(Inlämningsuppgift1.Data.eventsDbContext context)
        {
            _context = context;
        }

        public Event Event { get; set; }

        [BindProperty]
        public Event AddEvent { get; set; }


        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Event = await _context.Event.FirstOrDefaultAsync(m => m.eventID == id);

            if (Event == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync() 
        {
            Event = await _context.Event.FirstOrDefaultAsync();
            await _context.Event.AddAsync(AddEvent);
            await _context.SaveChangesAsync();
            return Page();
        }
        
    }
}

