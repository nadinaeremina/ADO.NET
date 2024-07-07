using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Models
{
    public class Country_model
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Country_model(int _id, string _title)
        {
            Id = _id;
            Title = _title;
        }
        public override string ToString()
        {
            return $"{Id,5} {Title,25}";
        }
    }
}
