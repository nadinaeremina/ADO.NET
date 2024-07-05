using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Exam
{
    [Table(name: "Enents_categories")]
    public class Event_category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }

    }
}
