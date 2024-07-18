using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Exam
{
    [Table(name: "Clients")]
    public class Client
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string First_name { get; set; }
        [Required]
        public string Last_name { get; set; }
        [Required]
        public string Middle_name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required ]
        public DateTime Birthday { get; set; } 
    }
}
