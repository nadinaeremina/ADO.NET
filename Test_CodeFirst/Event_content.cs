using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Exam
{
    [Table(name: "Events_contents")]
    public class Event_content
    {
        [Key]
        public int Id { get; set; }
        public Event_name event_name { get; set; }
        [Required]
        public DateTime Date_ { get; set; }
        public Place place { get; set; }
        [Required]
        public string Description_ { get; set; }
        [Required]
        public int Min_age { get; set; }
        public byte[] Image_ { get; set; } 
        [Required]
        public int Max_tickets { get; set; }
        [Required]
        public int Sold_tickets { get; set; }
    }
}
