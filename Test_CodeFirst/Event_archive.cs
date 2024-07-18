using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Exam
{
    [Table(name: "Events_archives")]
    public class Event_archive
    {
        [Key]
        public int Id { get; set; }
        public Event_name event_name { get; set; }
        [Required]
        public DateTime Date_ { get; set; }
        public Place place { get; set; }
        public Event_content event_content { get; set; }
    }
}
