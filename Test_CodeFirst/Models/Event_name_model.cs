using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Models
{
    public class Event_name_model
    {
        //public int ID { get; set; }
        public string Title { get; set; }
        public int event_category { get; set; }
        public Event_name_model(/*int _id, */string _title, int _event_category)
        {
            //ID = _id;
            Title = _title;
            event_category = _event_category;
        }
        public override string ToString()
        {
            return $" {Title,15} {event_category, 15}";
        }
    }
}
