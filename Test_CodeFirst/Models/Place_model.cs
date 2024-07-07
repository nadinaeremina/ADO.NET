using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Models
{
    public class Place_model
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public City city { get; set; }
        public Place_model(int _id, string _title, City _city)
        {
            ID = _id;
            Title = _title;
            city = _city;
        }
        public override string ToString()
        {
            return $"{ID,5} {Title,15} {city,15} ";
        }
    }
}
