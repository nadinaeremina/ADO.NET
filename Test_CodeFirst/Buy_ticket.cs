using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Exam
{
    [Table(name: "Buy_ticket")]
    public class Buy_ticket
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public decimal Value { get; set; }
        [Required]
        public DateTime date_of_bought { get; set; }
        public Client client { get; set; }
        public Event_name event_name { get; set; }
    }
}
