using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Inlämningsuppgift1.Models;

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
            this.Database.EnsureCreated();
            if (this.Event.Any())
            {
                return;
            }
            this.Event.AddRange(new List<Models.Event>()
            {
                new Models.Event() { 
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
