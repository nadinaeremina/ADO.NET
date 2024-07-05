using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;// обязательно


namespace Exam
{
    class EventsDbContext: DbContext
    {
        public EventsDbContext() : base("name=Events") { }

        public DbSet<Buy_ticket> buy_Tickets { get; set; }
        public DbSet<Place> places { get; set; }
        public DbSet<City> cities { get; set; }
        public DbSet<Country> countries { get; set; }
        public DbSet<Client> clients { get; set; }
        public DbSet<Event_archive> event_archives { get; set; }
        public DbSet<Event_category> event_categories { get; set; }
        public DbSet<Event_content> event_Contents { get; set; }
        public DbSet<Event_name> event_Names { get; set; }
    }
}
