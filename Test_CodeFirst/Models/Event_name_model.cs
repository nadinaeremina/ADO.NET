using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Models
{
    public class Event_name_model
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public Event_category_model event_category { get; set; }
        public Event_name_model(int _id, string _title, Event_category_model _event_category)
        {
            ID = _id;
            Title = _title;
            event_category = event_category;
        }
        public override string ToString()
        {
            return $"{ID,5} {Title,15} {event_category, 15}";
        }
    }
}
