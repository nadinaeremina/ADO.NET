using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Models
{
    public class Event_archive_model
    {
        public int Id { get; set; }
        public Event_name_model event_name { get; set; }
        public DateTime Date { get; set; }
        public Place_model place { get; set; }
        public Event_content_model event_content { get; set; }
        public Event_archive_model(int _id, Event_name_model _event_name, DateTime _date, Place_model _place, Event_content_model _event_content)
        {
            Id = _id;
            event_name = _event_name;
            Date = _date;
            place = _place;
            event_content = _event_content;
        }
        public override string ToString()
        {
            return $"{Id,5} {event_name,25} {Date,15} {place} {event_content}";
        }
    }
}
