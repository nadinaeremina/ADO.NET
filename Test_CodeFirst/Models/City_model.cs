using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Models
{
    public class City_model
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Country_model country { get; set; }
        public City_model(int _id, string _title, Country_model _country)
        {
            Id = _id;
            Title = _title;
            country = _country;
        }
        public override string ToString()
        {
            return $"{Id,5} {Title,25} {country, 15}";
        }
    }
}
