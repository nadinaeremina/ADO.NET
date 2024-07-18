using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Models
{
    public class Event_content_model
    {
        public int Id { get; set; }
        public int event_name_id { get; set; }
        public DateTime Date_ { get; set; }
        public int place_id { get; set; }
        public string Description_ { get; set; }
        public int Min_age { get; set; }
        public byte[] Image_ { get; set; }
        public int Max_tickets { get; set; }
        public int Sold_tickets { get; set; }
        public Event_content_model(/*int _id,*/ int _event_name, DateTime _date, int _place, string _description, int _min_age, int _max_ticket, int _sold_tickets)
        {
            //Id = _id;
            event_name_id = _event_name;
            Date_ = _date;
            place_id = _place;
            Description_ = _description;
            Min_age = _min_age;
            Max_tickets = _max_ticket;
            Sold_tickets = _sold_tickets;
        }

        public override string ToString()
        {
            return $"{Id,5}  {Date_,15} {Description_, 30} {Min_age, 5} {Max_tickets, 5} {Sold_tickets, 5}";
        }
    }
}

