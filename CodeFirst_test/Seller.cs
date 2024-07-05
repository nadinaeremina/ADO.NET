using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst_test
{
    [Table(name: "Seller")]
    public class Seller
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string FN { get; set; }
        [Required]
        public string LN { get; set; }
        [Required]
        public double Salary { get; set; }
    }
}
