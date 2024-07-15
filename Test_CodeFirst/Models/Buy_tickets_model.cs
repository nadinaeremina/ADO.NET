using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Models
{
    public class Buy_tickets_model
    {
        //public int Id { get; set; }
        public decimal Value { get; set; }
        public DateTime date_of_bought { get; set; }
        public int client { get; set; }
        public int event_name { get; set; }
        public Buy_tickets_model(/*int _id,*/ decimal _value, DateTime _date_of_bought, int _client, int _event_name)
        {
            //Id = _id;
            Value = _value;
            date_of_bought = _date_of_bought;
            client = _client;
            event_name = _event_name;
        }
        public override string ToString()
        {
            return $" {Value,10} {date_of_bought,10} {client,25} {event_name,10}";
        }
    }
}
