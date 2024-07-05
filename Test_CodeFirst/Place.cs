using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exam
{
    [Table(name: "Places")]
    public class Place
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }
        public City city { get; set; }
    }
}
