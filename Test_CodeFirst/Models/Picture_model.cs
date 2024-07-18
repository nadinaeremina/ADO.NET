using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Exam.Data_Layer_folder.Date_Layer_model;

namespace Exam.Models
{
    public class Picture_model
    {
        //public int Id { get; set; }
        public string Title { get; set; }
        public byte[] Image_ { get; set; }
        public int event_Category { get; set; }
        public Picture_model(string _title, byte[] _image, int _event_category)
        {
            Title = _title;
            Image_ = _image;
            event_Category = _event_category;
        }
        public override string ToString()
        {
            return $" {Title,10} {event_Category,5}";
        }
    }
}

