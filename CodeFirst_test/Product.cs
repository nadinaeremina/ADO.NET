using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst_test
{
    [Table(name: "Products")]
    public class Product
    {
        [Key]
        public int ID { get; set; }
        public string NameProduct { get; set; }
        public Seller seller { get; set; }
        public Customer customer { get; set; }
    }
}
