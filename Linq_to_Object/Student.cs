using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Linq_to_Object
{
    public class Student
    {
        public int Age { get; set; }
        public string FN { get; set; }
        public string LN { get; set; }
        public string City { get; set; }
        public override string ToString()
        {
            return $"{FN,15} {LN,15} {City,15} {Age,5}";
        }
    }
}
