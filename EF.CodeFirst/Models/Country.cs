using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.CodeFirst.Models
{
    [Table (name:"Countries")]
    public class Country
    {
        [Key]
        public int ID { get; set; }
        public string NameCountry { get; set; }
    }
}
