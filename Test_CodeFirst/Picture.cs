using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace Exam
{
    [Table(name: "Pictures")]
    internal class Picture
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public byte[] Image_ { get; set; }
        public Event_category event_Category { get; set; }
    }
}
