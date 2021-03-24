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

        public DbSet<Event> Event { get; set; }
        public DbSet<Organizer> Organizer { get; set; }
        public DbSet<Attendee> Attendee { get; set; }

        public void Seed()
        {
            Database.EnsureCreated();

            RemoveRange(Event);
            RemoveRange(Organizer);
            RemoveRange(Attendee);

            //this.Organizer.Add(new Organizer() { name = "hej" });

            Event.AddRange(new List<Event>()
            {
                new Event() {
                    description="Hockey match",
                    place="Halmstad Arena",
                    adress="Arenavägen 1",
                    date=2021-04-22,
                    spots_available=302},

            //organizer=this.Organizer.Where().FirstOrDefault()},
            new Event() {
                    description="Fotbolls match",
                    place="Halmstad Arena",
                    adress="Arenavägen 1",
                    date=2021-04-2,
                    spots_available=302
                //organizer=org}
            } });
            SaveChanges();
        }
    }
}
