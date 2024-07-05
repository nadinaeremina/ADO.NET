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
            
            Event_category ec1 = new Event_category();

            ec1.Title = "Спектакль";
          
            db.event_categories.Add(ec1);
            db.SaveChanges();
            //Console.ReadKey();
            Console.WriteLine("Ok!");
        }
    }
}
