using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EF.CodeFirst.Models
{
    [Table (name:"Cities")]
    public class City
    {
        [Key]
        public int Id { get; set; }
        public string NameCity { get; set; }
        public Country country { get; set; }
    }
}
