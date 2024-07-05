using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_test
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new SaleDBContext();
            Seller s1 = new Seller();

            s1.FN = "FN";
            s1.LN = "LN";
            s1.Salary = 100;
            db.Sellers.Add(s1);
            db.SaveChanges();
            Console.ReadKey();
        }
    }
}
