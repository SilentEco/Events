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
        public eventsDbContext(DbContextOptions<eventsDbContext> options)
            : base(options)
        {
        }

        public DbSet<Event> Event { get; set; }
        public DbSet<Organizer> Organizer { get; set; }
        public DbSet<Attendee> Attendee { get; set; }

        public void Seed()
        {
            this.Database.EnsureCreated();

            if (this.Event.Any() ||
                this.Attendee.Any() ||
                this.Organizer.Any())
            {
                return;
            }


            Attendee.AddRange(new List<Attendee>()
            {
                new Attendee()
                {
                    
                    name="Kristopher",
                    email="kristopher@fakemail.com",
                    phone_number="0721234567"
                },
                new Attendee()
                {
                    name="Jimmy-John",
                    email="jimmy.j@fakemail.com",
                    phone_number="469128746"
                },
                new Attendee()
                {
                    name="Greta",
                    email="savetheplanet@fakemail.com",
                    phone_number="085559713"
                },
                new Attendee()
                {
                    name="Snobben",
                    email="waliwasika@fakemail.com",
                    phone_number="0736119488"
                },
                new Attendee()
                {
                    name="Tarzan",
                    email="janenme@fakemail.com",
                    phone_number="0384562199"
                }
            });
            SaveChanges();
            Organizer.AddRange(new List<Organizer>()
            {
                new Organizer()
                {
                    name="Cool Events 4 All",
                    email="ce4a@fakemail.com",
                    phone_number="06337388"
                },
                new Organizer()
                {
                    name="Sports Center",
                    email="sport-center@fakemail.com",
                    phone_number="4672123667"
                },
                new Organizer()
                {
                    name="Real Event Promise",
                    email="totally_real@fakemail.com",
                    phone_number="123456789"
                }
            });
            SaveChanges();
            Event.AddRange(new List<Event>()
            {
            new Event() {
             description="Hockey match",
             place="Halmstad Arena",
             adress="Arenavägen 1",
             date=2021-04-22,
             spots_available=302,
             organizer = Organizer.Where(o => o.name=="Cool Events 4 All").FirstOrDefault()
            },
            new Event() {
             description="Monster Truck",
             place="Halmstad Arena",
             adress="Arenavägen 1",
             date=2021-04-22,
             spots_available=302,
             organizer = Organizer.Where(o => o.name=="Cool Events 4 All").FirstOrDefault()
            },
            new Event() {
             description="Fotbolls match",
             place="Halmstad Arena",
             adress="Arenavägen 1",
             date=2021-04-2,
             spots_available=302,
             organizer = Organizer.Where(o => o.name=="Cool Events 4 All").FirstOrDefault()
            } });
            SaveChanges();
        }
    }
}
