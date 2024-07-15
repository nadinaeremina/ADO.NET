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
        public int city_id { get; set; }
        public Place_model(/*int _id, */string _title, int _city_id)
        {
            // ID = _id;
            Title = _title;
            city_id = _city_id;
        }
        public override string ToString()
        {
            return $"{Title,15} {city_id,15} ";
        }
    }
}
