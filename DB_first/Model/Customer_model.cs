using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_first.Model
{
    public class Customer_model
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public byte[] Picture { get; set; }
        public override string ToString()
        {
            return $"{id,5} {LastName,15} {DateOfBirth,15}";
        }
    }
}
