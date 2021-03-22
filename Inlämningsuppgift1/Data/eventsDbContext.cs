using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Inlämningsuppgift1.Data
{
    public class eventsDbContext : DbContext
    {
        public eventsDbContext (DbContextOptions<eventsDbContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Event> Event { get; set; }

        public void Seed()
        {
            this.Event.RemoveRange();
            this.Event.AddRange(new List<Models.Event>()
            {
                new Models.Event() { 
                    organizerID=1,
                    description="Detta är en beskrivning",
                    place="Halmstad",
                    adress="Hvitfeldtsgatan 26a",
                    date=2021-03-21,
                    spots_available=30}
            });
            this.SaveChanges();
        }
    }
}
