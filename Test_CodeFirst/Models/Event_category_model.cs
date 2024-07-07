using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Models
{
    public class Event_category_model
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Event_category_model(int _id, string _title)
        {
            Id = _id;
            Title = _title;
        }
        public override string ToString()
        {
            return $"{Id,5} {Title,15} ";
        }
    }
}
