using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new EventsDbContext();

            Event_category event_cat = new Event_category();
            event_cat.Title = "Спектакль";

            Event_name event_name = new Event_name();
            event_name.Title = "Левша";
            event_name.event_category = event_cat;

            Country country = new Country();
            country.Title = "Россия";

            City city = new City();
            city.Title = "Санкт-Петербург";
            city.country = country;

            Place place_1 = new Place();
            place_1.Title = "ДК им.Ленсовета";
            place_1.city = city;

            Event_content event_con = new Event_content();
            event_con.event_name = event_name;
            event_con.Date = new DateTime(2024, 06, 21);
            event_con.place = place_1;
            event_con.Time = Convert.ToDateTime("18:25:00");
            event_con.Description = "Левша";
            event_con.Min_age = 7;
            event_con.Max_tickets = 700;
            event_con.Sold_tickets = 700;

            Client client_1 = new Client();
            client_1.First_name = "Иван";
            client_1.Last_name = "Иванов";
            client_1.Middle_name = "Иванович";
            client_1.Email = "ivan1@mail.ru";
            client_1.Birthday = new DateTime(2000,03,12);

            Buy_ticket buy_ticket = new Buy_ticket();
            buy_ticket.Value = 5000;
            buy_ticket.date_of_bought = new DateTime(2024,06,22);
            buy_ticket.client = client_1;
            buy_ticket.event_name = event_name;

            db.event_categories.Add(event_cat);
            db.event_Names.Add(event_name);
            db.countries.Add(country);
            db.cities.Add(city);
            db.places.Add(place_1);
            db.event_Contents.Add(event_con);
            db.clients.Add(client_1);
            db.buy_Tickets.Add(buy_ticket);

            db.SaveChanges();

            Console.WriteLine("Ok!");
        }
    }
}
