using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_to_SQL.Entity
{
    [Table (Name = "Teachers")]
    public class Teacher
    {
        //все св-ва 'public' // 'Column' - колонка // 'IsPrimaryKey' - ключ 
        // 'IsDbGenerated = true' - если identity // 'Column' - для всех полей
        // если просто 'Column' - то наше поле 'not null' // если может быть - 'CanBeNull = true'
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
        public bool IsAssistant { get; set; }
        [Column(CanBeNull = true)]
        public bool IsProfessor { get; set; }
        [Column]
        public int PositionId { get; set; }
        // для показа на консоли
        public override string ToString()
        {
            return $" {Id,5}  {Surname,15}  {Salary,10} ";
        }
    }
}
