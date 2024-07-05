using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Linq_to_SQL.Entity
{
    class Teacher
    {
        [Table (XName="Teachers")]
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column]
        public DateTime EmploymentDate { get; set; }
        [Column]
        public string Name_ { get; set; }
        [Column]
        public string Surname { get; set; }
        [Column]
        public decimal Premium { get; set; }
        [Column]
        public decimal Salary { get; set; }
        [Column(CanBeNull = true)]
        public bool IsAssistent { get; set; }
        [Column(CanBeNull = true)]
        public bool IsProfessor { get; set; }
        public override string ToString()
        {
            return $" {Id,5}  {Surname,15}  {Salary,10} ";
        }
    }
}
